using QuickFix.Fields;
using QuickFix.FIX44;

namespace FixSimulatorDesktop.FixApplication.Order
{
    public static class ExecutionReportBuilder
    {
        public static ExecutionReport NewFromNewOrderSingle(NewOrderSingle newOrderSingle)
        {
            var exReport = new ExecutionReport(
                new OrderID(Guid.NewGuid().ToString()),
                new ExecID(Guid.NewGuid().ToString()),
                new ExecType(ExecType.NEW),
                new OrdStatus(OrdStatus.NEW),
                newOrderSingle.Symbol,
                newOrderSingle.Side,
                new LeavesQty(0),
                new CumQty(newOrderSingle.OrderQty.getValue()),
                new AvgPx(newOrderSingle.Price.getValue()))
            {
                ClOrdID = new ClOrdID(Guid.NewGuid().ToString()),
                OrigClOrdID = new OrigClOrdID(newOrderSingle.ClOrdID.getValue()),
                OrderQty = new OrderQty(newOrderSingle.OrderQty.getValue()),
                TransactTime = new TransactTime(DateTime.Now)
            };

            if (newOrderSingle.IsSetAccount())
                exReport.SetField(newOrderSingle.Account);

            exReport.NoPartyIDs = new NoPartyIDs(0);
            return exReport;
        }

        public static ExecutionReport FilledFromNewOrderSingle(NewOrderSingle newOrderSingle)
        {
            var exReport = new ExecutionReport(
                new OrderID(Guid.NewGuid().ToString()),
                new ExecID(Guid.NewGuid().ToString()),
                new ExecType(ExecType.FILL),
                new OrdStatus(OrdStatus.FILLED),
                newOrderSingle.Symbol,
                newOrderSingle.Side,
                new LeavesQty(0),
                new CumQty(newOrderSingle.OrderQty.getValue()),
                new AvgPx(newOrderSingle.Price.getValue()))
            {
                ClOrdID = new ClOrdID(Guid.NewGuid().ToString()),
                OrigClOrdID = new OrigClOrdID(newOrderSingle.ClOrdID.getValue()),
                OrderQty = new OrderQty(newOrderSingle.OrderQty.getValue()),
                TransactTime = new TransactTime(DateTime.Now)
            };

            if (newOrderSingle.IsSetAccount())
                exReport.SetField(newOrderSingle.Account);

            exReport.NoPartyIDs = new NoPartyIDs(0);
            return exReport;
        }

        public static ExecutionReport PartiallyFilledFromNewOrderSingle(NewOrderSingle newOrderSingle, decimal qty)
        {
            var exReport = new ExecutionReport(
                new OrderID(Guid.NewGuid().ToString()),
                new ExecID(Guid.NewGuid().ToString()),
                new ExecType(qty == newOrderSingle.OrderQty.getValue() ? ExecType.FILL : ExecType.PARTIAL_FILL),
                new OrdStatus(qty == newOrderSingle.OrderQty.getValue() ? OrdStatus.FILLED : OrdStatus.PARTIALLY_FILLED),
                newOrderSingle.Symbol,
                newOrderSingle.Side,
                new LeavesQty(newOrderSingle.OrderQty.getValue() - qty),
                new CumQty(qty),
                new AvgPx(newOrderSingle.Price.getValue()))
            {
                ClOrdID = new ClOrdID(Guid.NewGuid().ToString()),
                OrigClOrdID = new OrigClOrdID(newOrderSingle.ClOrdID.getValue()),
                OrderQty = new OrderQty(newOrderSingle.OrderQty.getValue()),
                TransactTime = new TransactTime(DateTime.Now)
            };

            if (newOrderSingle.IsSetAccount())
                exReport.SetField(newOrderSingle.Account);

            exReport.NoPartyIDs = new NoPartyIDs(0);
            return exReport;
        }

        public static ExecutionReport ReplacedFromCancelReplaceRequest(OrderCancelReplaceRequest orderCancelReplaceRequest)
        {
            var exReport = new ExecutionReport(
                new OrderID(Guid.NewGuid().ToString()),
                new ExecID(Guid.NewGuid().ToString()),
                new ExecType(ExecType.REPLACED),
                new OrdStatus(OrdStatus.REPLACED),
                orderCancelReplaceRequest.Symbol,
                orderCancelReplaceRequest.Side,
                new LeavesQty(orderCancelReplaceRequest.OrderQty.getValue()),
                new CumQty(orderCancelReplaceRequest.OrderQty.getValue()),
                new AvgPx(orderCancelReplaceRequest.Price.getValue()))
            {
                ClOrdID = new ClOrdID(Guid.NewGuid().ToString()),
                OrigClOrdID = new OrigClOrdID(orderCancelReplaceRequest.ClOrdID.getValue()),
                OrderQty = new OrderQty(orderCancelReplaceRequest.OrderQty.getValue()),
                TransactTime = new TransactTime(DateTime.Now)
            };

            if (orderCancelReplaceRequest.IsSetAccount())
                exReport.SetField(orderCancelReplaceRequest.Account);

            exReport.NoPartyIDs = new NoPartyIDs(0);
            return exReport;
        }

        public static ExecutionReport ReplaceRejectionFromCancelReplaceRequest(OrderCancelReplaceRequest orderCancelReplaceRequest)
        {
            var exReport = new ExecutionReport(
                new OrderID(Guid.NewGuid().ToString()),
                new ExecID(Guid.NewGuid().ToString()),
                new ExecType(ExecType.REJECTED),
                new OrdStatus(OrdStatus.NEW),
                orderCancelReplaceRequest.Symbol,
                orderCancelReplaceRequest.Side,
                new LeavesQty(orderCancelReplaceRequest.OrderQty.getValue()),
                new CumQty(orderCancelReplaceRequest.OrderQty.getValue()),
                new AvgPx(orderCancelReplaceRequest.Price.getValue()))
            {
                ClOrdID = new ClOrdID(Guid.NewGuid().ToString()),
                OrigClOrdID = new OrigClOrdID(orderCancelReplaceRequest.ClOrdID.getValue()),
                OrderQty = new OrderQty(orderCancelReplaceRequest.OrderQty.getValue()),
                TransactTime = new TransactTime(DateTime.Now)
            };

            if (orderCancelReplaceRequest.IsSetAccount())
                exReport.SetField(orderCancelReplaceRequest.Account);

            exReport.NoPartyIDs = new NoPartyIDs(0);
            return exReport;
        }

        public static ExecutionReport CanceledFromCancelRequest(OrderCancelRequest orderCancelRequest)
        {
            var exReport = new ExecutionReport(
                new OrderID(Guid.NewGuid().ToString()),
                new ExecID(Guid.NewGuid().ToString()),
                new ExecType(ExecType.CANCELLED),
                new OrdStatus(OrdStatus.CANCELED),
                orderCancelRequest.Symbol,
                orderCancelRequest.Side,
                new LeavesQty(orderCancelRequest.OrderQty.getValue()),
                new CumQty(orderCancelRequest.OrderQty.getValue()),
                new AvgPx(0))
            {
                ClOrdID = new ClOrdID(Guid.NewGuid().ToString()),
                OrigClOrdID = new OrigClOrdID(orderCancelRequest.ClOrdID.getValue()),
                OrderQty = new OrderQty(orderCancelRequest.OrderQty.getValue()),
                TransactTime = new TransactTime(DateTime.Now)
            };

            if (orderCancelRequest.IsSetAccount())
                exReport.SetField(orderCancelRequest.Account);

            exReport.NoPartyIDs = new NoPartyIDs(0);
            return exReport;
        }

        public static ExecutionReport CancelRejectionFromCancelRequest(OrderCancelRequest orderCancelRequest)
        {
            var exReport = new ExecutionReport(
                new OrderID(Guid.NewGuid().ToString()),
                new ExecID(Guid.NewGuid().ToString()),
                new ExecType(ExecType.REJECTED),
                new OrdStatus(OrdStatus.NEW),
                orderCancelRequest.Symbol,
                orderCancelRequest.Side,
                new LeavesQty(orderCancelRequest.OrderQty.getValue()),
                new CumQty(orderCancelRequest.OrderQty.getValue()),
                new AvgPx(0))
            {
                ClOrdID = new ClOrdID(Guid.NewGuid().ToString()),
                OrigClOrdID = new OrigClOrdID(orderCancelRequest.ClOrdID.getValue()),
                OrderQty = new OrderQty(orderCancelRequest.OrderQty.getValue()),
                TransactTime = new TransactTime(DateTime.Now)
            };

            if (orderCancelRequest.IsSetAccount())
                exReport.SetField(orderCancelRequest.Account);

            exReport.NoPartyIDs = new NoPartyIDs(0);
            return exReport;
        }
    }
}
