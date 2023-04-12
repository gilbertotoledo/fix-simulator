using Microsoft.AspNetCore.Mvc;
using QuickFix;
using QuickFix.Fields;
using Serilog;
using System;

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
        public void SendDefaultNewOrderSingle()
        {
            _logger.Information("Sending a Default NewOrderSingle to all sessions");

            var order = new QuickFix.FIX44.NewOrderSingle
            {
                Account = new Account("123"),
                Symbol = new Symbol("PETR4"),
                OrdType = new OrdType(OrdType.MARKET),
                Side = new Side(Side.BUY),
                OrderQty = new OrderQty(100),
                Price = new Price(25),
                TransactTime = new TransactTime(DateTime.Now),
                ClOrdID = new ClOrdID(Guid.NewGuid().ToString()),
                NoPartyIDs = new NoPartyIDs(0)
            };

            ((InitiatorFixApp)_application).SendMessageToAllSessions(order);
        }

        [HttpPost("SendBatchDefaultNewOrderSingle")]
        public void SendBatchDefaultNewOrderSingle([FromBody] int qty)
        {
            _logger.Information($"Sending a batch with {qty} NewOrderSingle to all sessions");

            var order = new QuickFix.FIX44.NewOrderSingle
            {
                Account = new Account("123"),
                Symbol = new Symbol("PETR4"),
                OrdType = new OrdType(OrdType.MARKET),
                Side = new Side(Side.BUY),
                OrderQty = new OrderQty(100),
                Price = new Price(25),
                TransactTime = new TransactTime(DateTime.Now),
                ClOrdID = new ClOrdID(Guid.NewGuid().ToString()),
                NoPartyIDs = new NoPartyIDs(0)
            };

            for(int i = 1; i <= qty; i++)
            {
                order.ClOrdID = new ClOrdID($"{i}");
                ((InitiatorFixApp)_application).SendMessageToAllSessions(order);
            }
        }

        [HttpGet]
        public int GetNextMsgSeqNum()
        {
            return ((InitiatorFixApp)_application).GetNextSeqNum();
        }
    }
}
