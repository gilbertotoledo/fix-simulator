using FixSimulatorDesktop.Controller;
using FixSimulatorDesktop.FixApplication.Order;
using QuickFix;
using QuickFix.FIX44;
using Message = QuickFix.Message;

namespace Acceptor
{
    public class AcceptorFixApp : MessageCracker, IApplication
    {
        private readonly Action<string> _logger;
        private readonly Action<Message> _onMessageHandler;
        private readonly List<Session> _sessions = new();
        private NewOrderSingle _lastMessageReceived;

        public AcceptorFixApp(Action<string> logHandler, Action<Message> onMessageHandler)
        {
            _logger += logHandler;
            _onMessageHandler = onMessageHandler;
        }

        public void FromAdmin(Message message, SessionID sessionID)
        {

            if (message.Header.GetString(35) == "0")
                return;

            _logger.Invoke($"[FROM_ADMIN] NextTargetMsgSeqNum: {_sessions.FirstOrDefault()?.NextTargetMsgSeqNum} | NextSenderMsgSeqNum: {_sessions.FirstOrDefault()?.NextSenderMsgSeqNum}");
            _logger.Invoke($"FromAdmin {message}");
        }

        public void FromApp(Message message, SessionID sessionID)
        {
            //_logger.Invoke($"FromApp {message}");
            _logger.Invoke($"[FROM_APP] NextTargetMsgSeqNum: {_sessions.FirstOrDefault()?.NextTargetMsgSeqNum} | NextSenderMsgSeqNum: {_sessions.FirstOrDefault()?.NextSenderMsgSeqNum}");

            _onMessageHandler(message);
            Crack(message, sessionID);
        }

        public void OnCreate(SessionID sessionID)
        {
            try
            {
                _logger.Invoke($"OnCreate {sessionID}");
                var session = Session.LookupSession(sessionID);
                session.Logon();
                _sessions.Add(session);

                _logger.Invoke($"[ON_CREATE] NextTargetMsgSeqNum: {_sessions.FirstOrDefault()?.NextTargetMsgSeqNum} | NextSenderMsgSeqNum: {_sessions.FirstOrDefault()?.NextSenderMsgSeqNum}");
            }
            catch (Exception e)
            {
                _logger.Invoke($"OnCreate error {e.Message}");
            }
        }

        public void OnLogon(SessionID sessionID)
        {
            _logger.Invoke($"OnLogon {sessionID}");
        }

        public void OnLogout(SessionID sessionID)
        {
            _logger.Invoke($"OnLogout {sessionID}");
        }

        public void ToAdmin(Message message, SessionID sessionID)
        {
            if (message.Header.GetString(35) == "0")
                return;

            _logger.Invoke($"[TO_ADMIN] NextTargetMsgSeqNum: {_sessions.FirstOrDefault()?.NextTargetMsgSeqNum} | NextSenderMsgSeqNum: {_sessions.FirstOrDefault()?.NextSenderMsgSeqNum}");
            _logger.Invoke($"ToAdmin {message}");
        }

        public void ToApp(Message message, SessionID sessionId)
        {
            _logger.Invoke($"ToApp {message}");
        }

        public void OnMessage(QuickFix.FIX44.NewOrderSingle newOrderSingle, SessionID sessionID)
        {
            _logger.Invoke($"OnMessage_NewOrderSingle {newOrderSingle}");
            _lastMessageReceived = newOrderSingle;
            if (StateManager.AcceptorMacrosEnabled.ExecutionReportNew)
            {
                var er = ExecutionReportBuilder.NewFromNewOrderSingle(newOrderSingle);
                Send(er, sessionID);
            }

            if (StateManager.AcceptorMacrosEnabled.ExecutionReportFilled)
            {
                Thread.Sleep(2000);
                var er = ExecutionReportBuilder.FilledFromNewOrderSingle(newOrderSingle);
                Send(er, sessionID);
            }

            if (StateManager.AcceptorMacrosEnabled.ExecutionReportPartiallyFilledUnique)
            {
                Thread.Sleep(2000);
                var er = ExecutionReportBuilder.PartiallyFilledFromNewOrderSingle(newOrderSingle, newOrderSingle.OrderQty.getValue() * 0.25m);
                Send(er, sessionID);
            }

            if (StateManager.AcceptorMacrosEnabled.ExecutionReportPartiallyFilledScheduled)
            {
                Thread.Sleep(5000);
                var er = ExecutionReportBuilder.PartiallyFilledFromNewOrderSingle(newOrderSingle, newOrderSingle.OrderQty.getValue() * 0.25m);
                Send(er, sessionID);

                Thread.Sleep(5000);
                er = ExecutionReportBuilder.PartiallyFilledFromNewOrderSingle(newOrderSingle, newOrderSingle.OrderQty.getValue() * 0.5m);
                Send(er, sessionID);

                Thread.Sleep(5000);
                er = ExecutionReportBuilder.PartiallyFilledFromNewOrderSingle(newOrderSingle, newOrderSingle.OrderQty.getValue() * 0.75m);
                Send(er, sessionID);

                Thread.Sleep(5000);
                er = ExecutionReportBuilder.PartiallyFilledFromNewOrderSingle(newOrderSingle, newOrderSingle.OrderQty.getValue());
                Send(er, sessionID);
            }
        }

        public int GetNextSeqNum()
        {
            return _sessions.FirstOrDefault()?.NextTargetMsgSeqNum ?? 0;
        }

        public void SendErToLastMessage()
        {
            var er = ExecutionReportBuilder.NewFromNewOrderSingle(_lastMessageReceived);
            Send(er, _sessions.FirstOrDefault()?.SessionID);
        }

        private void Send(Message message, SessionID session)
        {
            try
            {
                _logger.Invoke($"[ANTES] NextTargetMsgSeqNum: {_sessions.FirstOrDefault()?.NextTargetMsgSeqNum} | NextSenderMsgSeqNum: {_sessions.FirstOrDefault()?.NextSenderMsgSeqNum}");

                Session.SendToTarget(message, session);

                _logger.Invoke($"[DEPOIS] NextTargetMsgSeqNum: {_sessions.FirstOrDefault()?.NextTargetMsgSeqNum} | NextSenderMsgSeqNum: {_sessions.FirstOrDefault()?.NextSenderMsgSeqNum}");
            }
            catch (SessionNotFound ex)
            {
                Console.WriteLine("==session not found exception!==");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
