using QuickFix;
using QuickFix.FIX44;
using Message = QuickFix.Message;

namespace FixApplication
{
    public class InitiatorFixApp : MessageCracker, IApplication
    {
        private readonly Action<string> _logger;
        private readonly Action<Message> _onMessageHandler;
        private readonly List<Session> _sessions = new();
        public List<Message> ReceivedMessages { get; } = new();
        
        public InitiatorFixApp(Action<string> logHandler, Action<Message> onMessageHandler)
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
            //_logger.Information($"FromApp {message}");
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
                _logger.Invoke($"OnCreate error {e}");
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
            _logger.Invoke($"[TO_APP] NextTargetMsgSeqNum: {_sessions.FirstOrDefault()?.NextTargetMsgSeqNum} | NextSenderMsgSeqNum: {_sessions.FirstOrDefault()?.NextSenderMsgSeqNum}");
            _logger.Invoke($"ToApp {message}");
        }

        public void OnMessage(QuickFix.FIX44.ExecutionReport executionReport, SessionID sessionID)
        {
            _logger.Invoke($"OnMessage_ExecutionReport {executionReport}");
            this.ReceivedMessages.Add(executionReport);
        }

        public void SendMessage(Message message, SessionID sessionID)
        {
            _sessions.Find(s => s.SessionID.Equals(sessionID))?.Send(message);
        }

        public void SendMessageToAllSessions(Message message)
        {
            _sessions.ForEach(session =>
            {
                try
                {
                    _logger.Invoke($"[ANTES] NextTargetMsgSeqNum: {_sessions.FirstOrDefault()?.NextTargetMsgSeqNum} | NextSenderMsgSeqNum: {_sessions.FirstOrDefault()?.NextSenderMsgSeqNum}");

                    session.Send(message);

                    _logger.Invoke($"[DEPOIS] NextTargetMsgSeqNum: {_sessions.FirstOrDefault()?.NextTargetMsgSeqNum} | NextSenderMsgSeqNum: {_sessions.FirstOrDefault()?.NextSenderMsgSeqNum}");
                }
                catch (Exception e)
                {
                    _logger.Invoke($"Error to send message: {message}");
                }
            });
        }

        public int GetNextSeqNum()
        {
            return _sessions.FirstOrDefault()?.NextTargetMsgSeqNum ?? 0;
        }

        public IEnumerable<string> GetExecutions(string clOrderId)
        {
            return this.ReceivedMessages
                    .Where(m =>
                        (m as ExecutionReport).ClOrdID.getValue() == clOrderId)
                .Select(m => (m as ExecutionReport).ToString().Replace("\u0001", "|"));
        }
    }
}
