using Microsoft.AspNetCore.Mvc;
using QuickFix;
using QuickFix.Fields;
using QuickFix.FIX44;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Initiator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IApplication _application;

        public OrderController(ILogger logger, IApplication application)
        {
            _logger = logger;
            _application = application;
        }

        [HttpPost("SendDefaultNewOrderSingle")]
        public IEnumerable<string> SendDefaultNewOrderSingle()
        {
            _logger.Information("Sending a Default NewOrderSingle to all sessions");

            var order = BuildNewOrderSingle();

            ((InitiatorFixApp)_application).SendMessageToAllSessions(order);

            Thread.Sleep(3000);
            return ((InitiatorFixApp)_application).GetExecutions(order.ClOrdID.getValue());
        }

        [HttpPost("SendDefaultReplaceOrder")]
        public IEnumerable<string> SendDefaultReplaceOrder([FromBody] string origClOrderId)
        {
            _logger.Information("Sending a Default OrderCancelReplaceRequest to all sessions");

            var order = BuildOrderCancelReplaceRequest(origClOrderId);

            ((InitiatorFixApp)_application).SendMessageToAllSessions(order);

            Thread.Sleep(3000);
            return ((InitiatorFixApp)_application).GetExecutions(order.ClOrdID.getValue());
        }

        [HttpPost("SendBatchDefaultNewOrderSingle")]
        public void SendBatchDefaultNewOrderSingle([FromBody] int qty)
        {
            _logger.Information($"Sending a batch with {qty} NewOrderSingle to all sessions");

            var order = new QuickFix.FIX44.NewOrderSingle
            {
                Account = new Account("840862"),
                Symbol = new Symbol("PETR4"),
                OrdType = new OrdType(OrdType.MARKET),
                Side = new Side(Side.BUY),
                OrderQty = new OrderQty(100),
                Price = new Price(2),
                TransactTime = new TransactTime(DateTime.Now),
                ClOrdID = new ClOrdID(Guid.NewGuid().ToString()),
                NoPartyIDs = new NoPartyIDs(1),
                TimeInForce = new TimeInForce(TimeInForce.DAY),
                ExpireDate = new ExpireDate(DateTime.Now.ToString("yyyyMMdd")),
                TradeDate = new TradeDate(DateTime.Now.ToString("yyyyMMdd")),
                Text = new Text("DEV_TEST_BASKET"),
            };
            order.AddGroup(new QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup()
            {
                PartyRole = new PartyRole(36),
                PartyID = new PartyID("840862")
            });

            for (int i = 1; i <= qty; i++)
            {
                order.ClOrdID = new ClOrdID($"{i}");
                ((InitiatorFixApp)_application).SendMessageToAllSessions(order);
            }
        }

        private NewOrderSingle BuildNewOrderSingle()
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

        private OrderCancelReplaceRequest BuildOrderCancelReplaceRequest(string origClOrderId)
        {
            var order = new QuickFix.FIX44.OrderCancelReplaceRequest(
                new OrigClOrdID(origClOrderId),
                new ClOrdID(Guid.NewGuid().ToString()),
                new Symbol("PETR4"),
                new Side(Side.BUY),
                new TransactTime(DateTime.Now),
                new OrdType(OrdType.MARKET))
            {
                Account = new Account("840862"),
                OrderQty = new OrderQty(100),
                OrdType = new OrdType('1'), //market
                Price = new Price(10),
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
    }
}
