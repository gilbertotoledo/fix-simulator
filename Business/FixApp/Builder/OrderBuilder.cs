using Business.FixApp.Builder;
using QuickFix.Fields;
using QuickFix.FIX44;
using Message = QuickFix.FIX44.Message;

namespace Business.FixApp.Order
{
    public static class OrderBuilder
    {
        public static NewOrderSingle NewOrderSingle(string account, string symbol, char side, string operation, decimal price, decimal quantity, string text = "FIX_SIMULATOR")
        {
            var order = new NewOrderSingle(
                new ClOrdID(Guid.NewGuid().ToString()),
                new Symbol(symbol),
                new Side(side),
                new TransactTime(DateTime.Now),
                new OrdType(OrdType.MARKET))
            {
                Account = new Account(account),
                OrderQty = new OrderQty(quantity),
                Price = new Price(price),
                NoPartyIDs = new NoPartyIDs(3),
                TimeInForce = new TimeInForce(TimeInForce.DAY),
                ExpireDate = new ExpireDate(DateTime.Now.ToString("yyyyMMdd")),
                TradeDate = new TradeDate(DateTime.Now.ToString("yyyyMMdd")),
                Text = new Text(text),
            };
            order.SetField(new StringField(10122, operation));

            order.AddDefaultGroups(account);
            order.SetBodyLenght();
            order.SetCheckSum();

            return order;
        }

        public static OrderCancelReplaceRequest OrderCancelReplaceRequest(Message message, int newQty, decimal newPrice, string text = "FIX_SIMULATOR_REPLACE")
        {
            var order = new OrderCancelReplaceRequest(
                new OrigClOrdID(message.GetString(new ClOrdID().Tag)),
                new ClOrdID(Guid.NewGuid().ToString()),
                new Symbol(message.GetString(new Symbol().Tag)),
                new Side(message.GetChar(new Side().Tag)),
                new TransactTime(DateTime.Now),
                new OrdType(OrdType.MARKET))
            {
                Account = new Account(message.GetString(new Account().Tag)),
                OrderQty = new OrderQty(newQty),
                OrdType = new OrdType(OrdType.MARKET), //market
                Price = new Price(newPrice),
                NoPartyIDs = new NoPartyIDs(3),
                TimeInForce = new TimeInForce(TimeInForce.DAY),
                ExpireDate = new ExpireDate(DateTime.Now.ToString("yyyyMMdd")),
                TradeDate = new TradeDate(DateTime.Now.ToString("yyyyMMdd")),
                Text = new Text(text),
            };
            order.SetField(new StringField(10122, message.GetString(10122)));

            order.AddDefaultGroups(message.GetString(new Account().Tag));
            order.SetBodyLenght();
            order.SetCheckSum();

            return order;
        }

        public static OrderCancelRequest OrderCancelRequest(Message message, string text = "FIX_SIMULATOR_CANCEL")
        {
            var order = new OrderCancelRequest(
                new OrigClOrdID(message.GetString(new ClOrdID().Tag)),
                new ClOrdID(Guid.NewGuid().ToString()),
                new Symbol(message.GetString(new Symbol().Tag)),
                new Side(message.GetChar(new Side().Tag)),
                new TransactTime(DateTime.Now))
            {
                Account = new Account(message.GetString(new Account().Tag)),
                NoPartyIDs = new NoPartyIDs(3),
                Text = new Text(text),
            };
            order.SetField(new StringField(10122, message.GetString(10122)));

            order.AddDefaultGroups(message.GetString(new Account().Tag));
            order.SetBodyLenght();
            order.SetCheckSum();

            return order;
        }
    }
}
