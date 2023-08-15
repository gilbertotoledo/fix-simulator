using FixSimulatorDesktop.Controller;
using FixSimulatorDesktop.FixApplication.Order;
using QuickFix;
using QuickFix.FIX44;
using Message = QuickFix.Message;

namespace FixSimulatorDesktop.FixApp
{
    public class AcceptorFixApp : FixApplicationBase
    {
        public AcceptorFixApp(Action<string> logHandler, Action<Message> onMessageHandler)
            :base(logHandler, onMessageHandler, "acceptor")
        {}

        public void OnMessage(NewOrderSingle newOrderSingle, SessionID sessionID)
        {
            _logger.Invoke($"[NEW_ORDER_SINGLE] {newOrderSingle}");
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
                Thread.Sleep(StateManager.AcceptorMacrosEnabled.ExecutionReportPartiallyFilledScheduledIntervalMilis);
                var er = ExecutionReportBuilder.PartiallyFilledFromNewOrderSingle(newOrderSingle, newOrderSingle.OrderQty.getValue() * 0.25m);
                Send(er, sessionID);

                Thread.Sleep(StateManager.AcceptorMacrosEnabled.ExecutionReportPartiallyFilledScheduledIntervalMilis);
                er = ExecutionReportBuilder.PartiallyFilledFromNewOrderSingle(newOrderSingle, newOrderSingle.OrderQty.getValue() * 0.5m);
                Send(er, sessionID);

                Thread.Sleep(StateManager.AcceptorMacrosEnabled.ExecutionReportPartiallyFilledScheduledIntervalMilis);
                er = ExecutionReportBuilder.PartiallyFilledFromNewOrderSingle(newOrderSingle, newOrderSingle.OrderQty.getValue() * 0.75m);
                Send(er, sessionID);

                Thread.Sleep(StateManager.AcceptorMacrosEnabled.ExecutionReportPartiallyFilledScheduledIntervalMilis);
                er = ExecutionReportBuilder.PartiallyFilledFromNewOrderSingle(newOrderSingle, newOrderSingle.OrderQty.getValue());
                Send(er, sessionID);
            }
        }

        public void OnMessage(OrderCancelReplaceRequest orderCancelReplaceRequest, SessionID sessionID)
        {
            _logger.Invoke($"[REPLACE_REQUEST] {orderCancelReplaceRequest}");

            if (StateManager.AcceptorMacrosEnabled.ExecutionReportReplaced)
            {
                Thread.Sleep(2000);
                var er = ExecutionReportBuilder.ReplacedFromCancelReplaceRequest(orderCancelReplaceRequest);
                Send(er, sessionID);
            }

            if (StateManager.AcceptorMacrosEnabled.ExecutionReportReplaceReject)
            {
                Thread.Sleep(2000);
                var er = ExecutionReportBuilder.ReplaceRejectionFromCancelReplaceRequest(orderCancelReplaceRequest);
                Send(er, sessionID);
            }
        }

        public void OnMessage(OrderCancelRequest orderCancelRequest, SessionID sessionID)
        {
            _logger.Invoke($"[CANCEL_REQUEST] {orderCancelRequest}");

            if (StateManager.AcceptorMacrosEnabled.ExecutionReportCanceled)
            {
                Thread.Sleep(2000);
                var er = ExecutionReportBuilder.CanceledFromCancelRequest(orderCancelRequest);
                Send(er, sessionID);
            }

            if (StateManager.AcceptorMacrosEnabled.ExecutionReportCancelReject)
            {
                Thread.Sleep(2000);
                var er = ExecutionReportBuilder.CancelRejectionFromCancelRequest(orderCancelRequest);
                Send(er, sessionID);
            }
        }

        public void SendErNewToLastMessage()
        {
            var er = ExecutionReportBuilder.NewFromNewOrderSingle((NewOrderSingle)ReceivedMessages.LastOrDefault());
            Send(er, _sessions.FirstOrDefault()?.SessionID);
        }

        public void SendErFilledToLastMessage()
        {
            var er = ExecutionReportBuilder.FilledFromNewOrderSingle((NewOrderSingle)ReceivedMessages.LastOrDefault());
            Send(er, _sessions.FirstOrDefault()?.SessionID);
        }
    }
}
