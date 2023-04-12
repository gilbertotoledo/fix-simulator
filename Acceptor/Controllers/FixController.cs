using Microsoft.AspNetCore.Mvc;
using QuickFix;
using Serilog;

namespace Acceptor.Controllers
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

        [HttpGet("GetNextMsgSeqNum")]
        public int GetNextMsgSeqNum()
        {
            return ((AcceptorFixApp)_application).GetNextSeqNum();
        }
    }
}