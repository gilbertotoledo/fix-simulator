using QuickFix;
using QuickFix.Fields;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Acceptor
{
    public class AcceptorFixApp : MessageCracker, IApplication
    {
        private readonly ILogger _logger;
        private readonly List<Session> _sessions = new();

        public AcceptorFixApp(ILogger logger)
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

        public void OnMessage(QuickFix.FIX44.NewOrderSingle newOrderSingle, SessionID sessionID)
        {
            _logger.Information($"OnMessage_NewOrderSingle {newOrderSingle}");
            SendExecutionReport(newOrderSingle, sessionID);
        }

        public int GetNextSeqNum()
        {
            return _sessions.FirstOrDefault()?.NextTargetMsgSeqNum ?? 0;
        }

        private void SendExecutionReport(QuickFix.FIX44.NewOrderSingle newOrderSingle, SessionID session)
        {
            QuickFix.FIX44.ExecutionReport exReport = new QuickFix.FIX44.ExecutionReport(
                new OrderID(Guid.NewGuid().ToString()),
                new ExecID(Guid.NewGuid().ToString()),
                new ExecType(ExecType.FILL),
                new OrdStatus(OrdStatus.FILLED),
                newOrderSingle.Symbol,
                newOrderSingle.Side,
                new LeavesQty(0),
                new CumQty(newOrderSingle.OrderQty.getValue()),
                new AvgPx(newOrderSingle.Price.getValue()));

            if (newOrderSingle.IsSetAccount())
                exReport.SetField(newOrderSingle.Account);

            exReport.NoPartyIDs = new NoPartyIDs(0);

            exReport.OrdStatus = new OrdStatus(OrdStatus.NEW);

            try
            {
                Session.SendToTarget(exReport, session);
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
