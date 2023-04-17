using QuickFix;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Initiator
{
    public class InitiatorFixApp : MessageCracker, IApplication
    {
        private readonly ILogger _logger;
        private readonly List<Session> _sessions = new();

        public InitiatorFixApp(ILogger logger)
        {
            _logger = logger;
        }

        public void FromAdmin(Message message, SessionID sessionID)
        {
            if (message.Header.GetString(35) == "0")
                return;

            _logger.Information($"FromAdmin {message}");
        }

        public void FromApp(Message message, SessionID sessionID)
        {
            //_logger.Information($"FromApp {message}");
            Crack(message, sessionID);
        }

        public void OnCreate(SessionID sessionID)
        {
            try
            {
                _logger.Information($"OnCreate {sessionID}");
                var session = Session.LookupSession(sessionID);
                session.Logon();
                _sessions.Add(session);
            }
            catch (Exception e)
            {
                _logger.Error(e, "OnCreate error");
            }
        }

        public void OnLogon(SessionID sessionID)
        {
            _logger.Information($"OnLogon {sessionID}");
        }

        public void OnLogout(SessionID sessionID)
        {
            _logger.Information($"OnLogout {sessionID}");
        }

        public void ToAdmin(Message message, SessionID sessionID)
        {
            if (message.Header.GetString(35) == "0")
                return;

            _logger.Information($"ToAdmin {message}");
        }

        public void ToApp(Message message, SessionID sessionId)
        {
            _logger.Information($"ToApp {message}");
        }

        public void OnMessage(QuickFix.FIX44.ExecutionReport executionReport, SessionID sessionID)
        {
            _logger.Information($"OnMessage_ExecutionReport {executionReport}");
        }

        public void SendMessage(Message message, SessionID sessionID)
        {
            _sessions.FirstOrDefault(s => s.SessionID.Equals(sessionID))?.Send(message);
        }

        public void SendMessageToAllSessions(Message message)
        {
            _sessions.ForEach(session =>
            {
                try
                {
                    session.Send(message);
                } catch(Exception e)
                {
                    _logger.Error(e, "Error to send message: {message}", message);
                }
            });
        }

        public int GetNextSeqNum()
        {
            return _sessions.FirstOrDefault()?.NextTargetMsgSeqNum ?? 0;
        }
    }
}
