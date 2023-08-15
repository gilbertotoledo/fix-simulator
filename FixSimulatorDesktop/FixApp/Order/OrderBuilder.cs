using QuickFix;
using QuickFix.Fields;
using QuickFix.FIX44;
using Message = QuickFix.FIX44.Message;

namespace FixSimulatorDesktop.FixApplication.Order
{
    public static class OrderBuilder
    {

        public static NewOrderSingle NewOrderSingle()
        {
            var order = new QuickFix.FIX44.NewOrderSingle(
                new ClOrdID(Guid.NewGuid().ToString()),
                new Symbol("PETR4"),
                new Side(Side.BUY),
                new TransactTime(DateTime.Now),
                new OrdType(OrdType.MARKET))
            {
                Account = new Account("840862"),
                OrderQty = new OrderQty(100),
                Price = new Price(5),
                NoPartyIDs = new NoPartyIDs(1),
                TimeInForce = new TimeInForce(TimeInForce.DAY),
                ExpireDate = new ExpireDate(DateTime.Now.ToString("yyyyMMdd")),
                TradeDate = new TradeDate(DateTime.Now.ToString("yyyyMMdd")),
                Text = new Text("DEV_TEST"),
            };
            order.SetField(new StringField(10122, "POSITION"));
            order.AddGroup(new QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup()
            {
                PartyRole = new PartyRole(36),
                PartyID = new PartyID("840862"),
                PartyIDSource = new PartyIDSource('D')
            });
            order.AddGroup(new QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup()
            {
                PartyRole = new PartyRole(7),
                PartyID = new PartyID("4090"),
                PartyIDSource = new PartyIDSource('D')
            });
            order.AddGroup(new QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup()
            {
                PartyRole = new PartyRole(54),
                PartyID = new PartyID("DMA1"),
                PartyIDSource = new PartyIDSource('D')
            });
            order.Header.SetField(new BodyLength(order.Header.CalculateLength() + order.CalculateLength() + order.Trailer.CalculateLength()));
            order.Trailer.SetField(new CheckSum(order.CheckSum().ToString()));

            return order;
        }

        public static OrderCancelReplaceRequest OrderCancelReplaceRequest(Message message, int newQty, decimal newPrice)
        {
            var order = new QuickFix.FIX44.OrderCancelReplaceRequest(
                new OrigClOrdID(message.GetString(new ClOrdID().Tag)),
                new ClOrdID(Guid.NewGuid().ToString()),
                new Symbol("PETR4"),
                new Side(Side.BUY),
                new TransactTime(DateTime.Now),
                new OrdType(OrdType.MARKET))
            {
                Account = new Account("840862"),
                OrderQty = new OrderQty(newQty),
                OrdType = new OrdType('1'), //market
                Price = new Price(newPrice),
                NoPartyIDs = new NoPartyIDs(3),
                TimeInForce = new TimeInForce(TimeInForce.DAY),
                ExpireDate = new ExpireDate(DateTime.Now.ToString("yyyyMMdd")),
                TradeDate = new TradeDate(DateTime.Now.ToString("yyyyMMdd")),
                Text = new Text("REPLACE_DEV_TEST"),
            };
            order.SetField(new StringField(10122, "POSITION"));
            order.AddGroup(new QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup()
            {
                PartyRole = new PartyRole(36),
                PartyID = new PartyID("840862"),
                PartyIDSource = new PartyIDSource('D')
            });
            order.AddGroup(new QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup()
            {
                PartyRole = new PartyRole(7),
                PartyID = new PartyID("4090"),
                PartyIDSource = new PartyIDSource('D')
            });
            order.AddGroup(new QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup()
            {
                PartyRole = new PartyRole(54),
                PartyID = new PartyID("DMA1"),
                PartyIDSource = new PartyIDSource('D')
            });
            order.Header.SetField(new BodyLength(order.Header.CalculateLength() + order.CalculateLength() + order.Trailer.CalculateLength()));
            order.Trailer.SetField(new CheckSum(order.CheckSum().ToString()));

            return order;
        }


        public static OrderCancelRequest OrderCancelRequest(Message message)
        {
            var order = new QuickFix.FIX44.OrderCancelRequest(
                new OrigClOrdID(message.GetString(new ClOrdID().Tag)),
                new ClOrdID(Guid.NewGuid().ToString()),
                new Symbol("PETR4"),
                new Side(Side.BUY),
                new TransactTime(DateTime.Now))
            {
                Account = new Account("840862"),
                NoPartyIDs = new NoPartyIDs(3),
                Text = new Text("CANCEL_DEV_TEST"),
            };
            order.SetField(new StringField(10122, "POSITION"));
            order.AddGroup(new QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup()
            {
                PartyRole = new PartyRole(36),
                PartyID = new PartyID("840862"),
                PartyIDSource = new PartyIDSource('D')
            });
            order.AddGroup(new QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup()
            {
                PartyRole = new PartyRole(7),
                PartyID = new PartyID("4090"),
                PartyIDSource = new PartyIDSource('D')
            });
            order.AddGroup(new QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup()
            {
                PartyRole = new PartyRole(54),
                PartyID = new PartyID("DMA1"),
                PartyIDSource = new PartyIDSource('D')
            });
            order.Header.SetField(new BodyLength(order.Header.CalculateLength() + order.CalculateLength() + order.Trailer.CalculateLength()));
            order.Trailer.SetField(new CheckSum(order.CheckSum().ToString()));

            return order;
        }
    }
}
