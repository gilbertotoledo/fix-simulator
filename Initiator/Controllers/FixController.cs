using Microsoft.AspNetCore.Mvc;
using QuickFix;
using Serilog;

namespace Initiator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FixController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IApplication _application;

        public FixController(ILogger logger, IApplication application)
        {
            _logger = logger;
            _application = application;
        }

        [HttpPost]
        public bool DisconnectAll()
        {
            _logger.Information("Disconnecting all...");

            return true;
        }

        [HttpGet("GetNextMsgSeqNum")]
        public int GetNextMsgSeqNum()
        {
            return ((InitiatorFixApp)_application).GetNextSeqNum();
        }
    }
}