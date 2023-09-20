using Business.FixApp.Order;
using Business.State;
using QuickFix;
using QuickFix.FIX44;
using Message = QuickFix.Message;

namespace Business.FixApp
{
    public class FixApplicationBase : MessageCracker, IApplication
    {
        protected readonly Action<string> _logger;
        protected readonly Action<Message> _onMessageHandler;
        protected readonly List<Session> _sessions = new();
        protected string ApplicationType { get; private set; }

        public List<Message> SentMessages { get; } = new();
        public List<Message> ReceivedMessages { get; } = new();

        public FixApplicationBase(Action<string> logHandler, Action<Message> onMessageHandler, string applicationType)
        {
            _logger += logHandler;
            _onMessageHandler = onMessageHandler;
            ApplicationType = applicationType;
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
            _logger.Invoke($"[FROM_APP] NextTargetMsgSeqNum: {_sessions.FirstOrDefault()?.NextTargetMsgSeqNum} | NextSenderMsgSeqNum: {_sessions.FirstOrDefault()?.NextSenderMsgSeqNum}");

            if (ApplicationType.Equals("acceptor") && StateManager.IsAcceptorShowMessagesReceived ||
                 ApplicationType.Equals("initiator") && StateManager.IsInitiatorShowMessagesReceived)
            {
                _onMessageHandler(message);
            }

            ReceivedMessages.Add(message);
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
            if (ApplicationType.Equals("acceptor") && StateManager.IsAcceptorShowMessagesSent ||
                 ApplicationType.Equals("initiator") && StateManager.IsInitiatorShowMessagesSent)
            {
                _onMessageHandler(message);
            }

            SentMessages.Add(message);
            _logger.Invoke($"ToApp {message}");
        }

        public async Task SendAsync(Message message)
        {
            await Task.Run(() =>
            {
                _logger.Invoke($"[ANTES] NextTargetMsgSeqNum: {_sessions.FirstOrDefault()?.NextTargetMsgSeqNum} | NextSenderMsgSeqNum: {_sessions.FirstOrDefault()?.NextSenderMsgSeqNum}");
                _sessions.ForEach(session =>
                {
                    Send(message, session.SessionID);
                });
                _logger.Invoke($"[DEPOIS] NextTargetMsgSeqNum: {_sessions.FirstOrDefault()?.NextTargetMsgSeqNum} | NextSenderMsgSeqNum: {_sessions.FirstOrDefault()?.NextSenderMsgSeqNum}");
            });

        }

        public void Send(Message message, SessionID sessionID)
        {
            try
            {
                Session.SendToTarget(message, sessionID);
            }
            catch (SessionNotFound ex)
            {
                _logger.Invoke($"SESSION NOT FOUND | {ex}");
            }
            catch (Exception ex)
            {
                _logger.Invoke($"EXCEPTION | {ex}");
            }
        }

        public IEnumerable<string> GetExecutions(string clOrderId)
        {
            return ReceivedMessages
                    .Where(m =>
                        (m as ExecutionReport).ClOrdID.getValue() == clOrderId)
                .Select(m => (m as ExecutionReport).ToString().Replace("\u0001", "|"));
        }
    }
}
