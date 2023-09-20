using Business.FixApp.Builder;
using QuickFix.Fields;
using QuickFix.FIX44;

namespace Business.FixApp.Order
{
    public static class ExecutionReportBuilder
    {
        public static ExecutionReport NewFromNewOrderSingle(NewOrderSingle newOrderSingle, string applId = null)
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
                new AvgPx(0))
            {
                Account = newOrderSingle.Account,
                ClOrdID = new ClOrdID(Guid.NewGuid().ToString()),
                OrigClOrdID = new OrigClOrdID(newOrderSingle.ClOrdID.getValue()),
                OrderQty = new OrderQty(newOrderSingle.OrderQty.getValue()),
                TransactTime = new TransactTime(DateTime.Now)
            };

            exReport.SetApplId(applId);
            exReport.AddDefaultGroups(newOrderSingle.Account.getValue());

            if (newOrderSingle.GetChar(new OrdType().Tag) == OrdType.MARKET)
            {
                exReport.Price = new Price(10);
                exReport.AvgPx = new AvgPx(10);
            }
            else
            {
                exReport.Price = new Price(newOrderSingle.Price.getValue());
                exReport.AvgPx = new AvgPx(newOrderSingle.Price.getValue());
            }

            return exReport;
        }

        public static ExecutionReport FilledFromNewOrderSingle(NewOrderSingle newOrderSingle, string applId = null)
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
                new AvgPx(0))
            {
                Account = newOrderSingle.Account,
                ClOrdID = new ClOrdID(Guid.NewGuid().ToString()),
                OrigClOrdID = new OrigClOrdID(newOrderSingle.ClOrdID.getValue()),
                OrderQty = new OrderQty(newOrderSingle.OrderQty.getValue()),
                TransactTime = new TransactTime(DateTime.Now)
            };

            exReport.SetApplId(applId);
            exReport.AddDefaultGroups(newOrderSingle.Account.getValue());

            if (newOrderSingle.GetChar(new OrdType().Tag) == OrdType.MARKET)
            {
                exReport.Price = new Price(10);
                exReport.AvgPx = new AvgPx(10);
            }
            else
            {
                exReport.Price = new Price(newOrderSingle.Price.getValue());
                exReport.AvgPx = new AvgPx(newOrderSingle.Price.getValue());
            }

            return exReport;
        }

        public static ExecutionReport FilledWithClOrderId(NewOrderSingle newOrderSingle, string clOrderId, string status, string applId = null)
        {
            var exReport = new ExecutionReport(
                new OrderID(Guid.NewGuid().ToString()),
                new ExecID(Guid.NewGuid().ToString()),
                new ExecType(status == "New" ? ExecType.NEW : ExecType.FILL),
                new OrdStatus(status == "New" ? OrdStatus.NEW : OrdStatus.FILLED),
                newOrderSingle.Symbol,
                newOrderSingle.Side,
                new LeavesQty(0),
                new CumQty(newOrderSingle.OrderQty.getValue()),
                new AvgPx(0))
            {
                Account = newOrderSingle.Account,
                ClOrdID = new ClOrdID(clOrderId),
                OrigClOrdID = new OrigClOrdID(clOrderId),
                OrderQty = new OrderQty(newOrderSingle.OrderQty.getValue()),
                TransactTime = new TransactTime(DateTime.Now)
            };

            exReport.SetApplId(applId);
            exReport.AddDefaultGroups(newOrderSingle.Account.getValue());

            if (newOrderSingle.GetChar(new OrdType().Tag) == OrdType.MARKET)
            {
                exReport.Price = new Price(10);
                exReport.AvgPx = new AvgPx(10);
            }
            else
            {
                exReport.Price = new Price(newOrderSingle.Price.getValue());
                exReport.AvgPx = new AvgPx(newOrderSingle.Price.getValue());
            }

            return exReport;
        }

        public static ExecutionReport PartiallyFilledFromNewOrderSingle(NewOrderSingle newOrderSingle, decimal qty, string applId = null)
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
                Account = newOrderSingle.Account,
                ClOrdID = new ClOrdID(Guid.NewGuid().ToString()),
                OrigClOrdID = new OrigClOrdID(newOrderSingle.ClOrdID.getValue()),
                OrderQty = new OrderQty(newOrderSingle.OrderQty.getValue()),
                TransactTime = new TransactTime(DateTime.Now)
            };

            exReport.SetApplId(applId);
            exReport.AddDefaultGroups(newOrderSingle.Account.getValue());
            
            return exReport;
        }

        public static ExecutionReport ReplacedFromCancelReplaceRequest(OrderCancelReplaceRequest orderCancelReplaceRequest, string applId = null)
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
                Account = orderCancelReplaceRequest.Account,
                ClOrdID = new ClOrdID(Guid.NewGuid().ToString()),
                OrigClOrdID = new OrigClOrdID(orderCancelReplaceRequest.ClOrdID.getValue()),
                OrderQty = new OrderQty(orderCancelReplaceRequest.OrderQty.getValue()),
                TransactTime = new TransactTime(DateTime.Now)
            };

            exReport.SetApplId(applId);
            exReport.AddDefaultGroups(orderCancelReplaceRequest.Account.getValue());

            return exReport;
        }

        public static ExecutionReport ReplaceRejectionFromCancelReplaceRequest(OrderCancelReplaceRequest orderCancelReplaceRequest, string applId = null)
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
                Account = orderCancelReplaceRequest.Account,
                ClOrdID = new ClOrdID(Guid.NewGuid().ToString()),
                OrigClOrdID = new OrigClOrdID(orderCancelReplaceRequest.ClOrdID.getValue()),
                OrderQty = new OrderQty(orderCancelReplaceRequest.OrderQty.getValue()),
                TransactTime = new TransactTime(DateTime.Now)
            };

            exReport.SetApplId(applId);
            exReport.AddDefaultGroups(orderCancelReplaceRequest.Account.getValue());

            return exReport;
        }

        public static ExecutionReport CanceledFromCancelRequest(OrderCancelRequest orderCancelRequest, string applId = null)
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
                Account = orderCancelRequest.Account,
                ClOrdID = new ClOrdID(Guid.NewGuid().ToString()),
                OrigClOrdID = new OrigClOrdID(orderCancelRequest.ClOrdID.getValue()),
                OrderQty = new OrderQty(orderCancelRequest.OrderQty.getValue()),
                TransactTime = new TransactTime(DateTime.Now)
            };

            exReport.SetApplId(applId);
            exReport.AddDefaultGroups(orderCancelRequest.Account.getValue());

            return exReport;
        }

        public static ExecutionReport CancelRejectionFromCancelRequest(OrderCancelRequest orderCancelRequest, string applId = null)
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
                Account = orderCancelRequest.Account,
                ClOrdID = new ClOrdID(Guid.NewGuid().ToString()),
                OrigClOrdID = new OrigClOrdID(orderCancelRequest.ClOrdID.getValue()),
                OrderQty = new OrderQty(orderCancelRequest.OrderQty.getValue()),
                TransactTime = new TransactTime(DateTime.Now)
            };

            exReport.SetApplId(applId);
            exReport.AddDefaultGroups(orderCancelRequest.Account.getValue());

            return exReport;
        }
    }
}
