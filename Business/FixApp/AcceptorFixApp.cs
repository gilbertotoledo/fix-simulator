using Business.FixApp.Order;
using Business.State;
using QuickFix;
using QuickFix.FIX44;
using Message = QuickFix.Message;

namespace Business.FixApp
{
    public class AcceptorFixApp : FixApplicationBase
    {
        public AcceptorFixApp(Action<string> logHandler, Action<Message> onMessageHandler)
            : base(logHandler, onMessageHandler, "acceptor")
        { }

        public void OnMessage(NewOrderSingle newOrderSingle, SessionID sessionID)
        {
            _logger.Invoke($"[NEW_ORDER_SINGLE] {newOrderSingle}");
            Task.Run(() =>
            {
                if (StateManager.AcceptorMacroExecutionReportNew)
                {
                    var er = ExecutionReportBuilder.NewFromNewOrderSingle(newOrderSingle);
                    Send(er, sessionID);
                }

                if (StateManager.AcceptorMacroExecutionReportFilled)
                {
                    Thread.Sleep(StateManager.AcceptorIntervalMilis);
                    var er = ExecutionReportBuilder.FilledFromNewOrderSingle(newOrderSingle);
                    Send(er, sessionID);
                }

                if (StateManager.AcceptorMacroExecutionReportPartiallyFilledUnique)
                {
                    Thread.Sleep(StateManager.AcceptorIntervalMilis);
                    var er = ExecutionReportBuilder.PartiallyFilledFromNewOrderSingle(newOrderSingle, newOrderSingle.OrderQty.getValue() * 0.25m);
                    Send(er, sessionID);
                }

                if (StateManager.AcceptorMacroExecutionReportPartiallyFilledScheduled)
                {
                    Thread.Sleep(StateManager.AcceptorIntervalMilis);
                    var er = ExecutionReportBuilder.PartiallyFilledFromNewOrderSingle(newOrderSingle, newOrderSingle.OrderQty.getValue() * 0.25m);
                    Send(er, sessionID);

                    Thread.Sleep(StateManager.AcceptorIntervalMilis);
                    er = ExecutionReportBuilder.PartiallyFilledFromNewOrderSingle(newOrderSingle, newOrderSingle.OrderQty.getValue() * 0.5m);
                    Send(er, sessionID);

                    Thread.Sleep(StateManager.AcceptorIntervalMilis);
                    er = ExecutionReportBuilder.PartiallyFilledFromNewOrderSingle(newOrderSingle, newOrderSingle.OrderQty.getValue() * 0.75m);
                    Send(er, sessionID);

                    Thread.Sleep(StateManager.AcceptorIntervalMilis);
                    er = ExecutionReportBuilder.PartiallyFilledFromNewOrderSingle(newOrderSingle, newOrderSingle.OrderQty.getValue());
                    Send(er, sessionID);
                }
            });
        }

        public void OnMessage(OrderCancelReplaceRequest orderCancelReplaceRequest, SessionID sessionID)
        {
            _logger.Invoke($"[REPLACE_REQUEST] {orderCancelReplaceRequest}");
            Task.Run(() =>
            {
                if (StateManager.AcceptorMacroExecutionReportReplaced)
                {
                    Thread.Sleep(StateManager.AcceptorIntervalMilis);
                    var er = ExecutionReportBuilder.ReplacedFromCancelReplaceRequest(orderCancelReplaceRequest);
                    Send(er, sessionID);
                }

                if (StateManager.AcceptorMacroExecutionReportReplaceReject)
                {
                    Thread.Sleep(StateManager.AcceptorIntervalMilis);
                    var er = ExecutionReportBuilder.ReplaceRejectionFromCancelReplaceRequest(orderCancelReplaceRequest);
                    Send(er, sessionID);
                }
            });
        }

        public void OnMessage(OrderCancelRequest orderCancelRequest, SessionID sessionID)
        {
            _logger.Invoke($"[CANCEL_REQUEST] {orderCancelRequest}");
            Task.Run(() =>
            {
                if (StateManager.AcceptorMacroExecutionReportCanceled)
                {
                    Thread.Sleep(StateManager.AcceptorIntervalMilis);
                    var er = ExecutionReportBuilder.CanceledFromCancelRequest(orderCancelRequest);
                    Send(er, sessionID);
                }

                if (StateManager.AcceptorMacroExecutionReportCancelReject)
                {
                    Thread.Sleep(StateManager.AcceptorIntervalMilis);
                    var er = ExecutionReportBuilder.CancelRejectionFromCancelRequest(orderCancelRequest);
                    Send(er, sessionID);
                }
            });
        }

        public async Task SendErNewToLastMessageAsync()
        {
            var er = ExecutionReportBuilder.NewFromNewOrderSingle((NewOrderSingle)ReceivedMessages.LastOrDefault());
            await SendAsync(er);
        }

        public async Task SendErFilledToLastMessageAsync()
        {
            var er = ExecutionReportBuilder.FilledFromNewOrderSingle((NewOrderSingle)ReceivedMessages.LastOrDefault());
            await SendAsync(er);
        }

        public async Task SendErFilledAsync(NewOrderSingle order, string clOrderId, string status, string applId)
        {
            var er = ExecutionReportBuilder.FilledWithClOrderId(order, clOrderId, status, applId);
            await SendAsync(er);
        }
    }
}
