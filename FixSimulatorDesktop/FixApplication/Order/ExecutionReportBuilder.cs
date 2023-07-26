using QuickFix.Fields;
using QuickFix.FIX44;

namespace FixSimulatorDesktop.FixApplication.Order
{
    public static class ExecutionReportBuilder
    {
        public static ExecutionReport NewFromNewOrderSingle(NewOrderSingle newOrderSingle)
        {
            ExecutionReport exReport = new QuickFix.FIX44.ExecutionReport(
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
                OrigClOrdID = new OrigClOrdID(newOrderSingle.ClOrdID.getValue())
            };

            if (newOrderSingle.IsSetAccount())
                exReport.SetField(newOrderSingle.Account);

            exReport.NoPartyIDs = new NoPartyIDs(0);
            return exReport;
        }

        public static ExecutionReport FilledFromNewOrderSingle(NewOrderSingle newOrderSingle)
        {
            ExecutionReport exReport = new QuickFix.FIX44.ExecutionReport(
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
                OrigClOrdID = new OrigClOrdID(newOrderSingle.ClOrdID.getValue())
            };

            if (newOrderSingle.IsSetAccount())
                exReport.SetField(newOrderSingle.Account);

            exReport.NoPartyIDs = new NoPartyIDs(0);
            return exReport;
        }

        public static ExecutionReport PartiallyFilledFromNewOrderSingle(NewOrderSingle newOrderSingle, decimal qty)
        {
            ExecutionReport exReport = new QuickFix.FIX44.ExecutionReport(
                new OrderID(Guid.NewGuid().ToString()),
                new ExecID(Guid.NewGuid().ToString()),
                new ExecType(ExecType.PARTIAL_FILL),
                new OrdStatus(OrdStatus.PARTIALLY_FILLED),
                newOrderSingle.Symbol,
                newOrderSingle.Side,
                new LeavesQty(newOrderSingle.OrderQty.getValue() - qty),
                new CumQty(qty),
                new AvgPx(newOrderSingle.Price.getValue()))
            {
                ClOrdID = new ClOrdID(Guid.NewGuid().ToString()),
                OrigClOrdID = new OrigClOrdID(newOrderSingle.ClOrdID.getValue())
            };

            if (newOrderSingle.IsSetAccount())
                exReport.SetField(newOrderSingle.Account);

            exReport.NoPartyIDs = new NoPartyIDs(0);
            return exReport;
        }
    }
}
