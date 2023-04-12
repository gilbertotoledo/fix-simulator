using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Initiator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FixController : ControllerBase
    {
        private readonly ILogger _logger;

        public FixController(ILogger logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public bool DisconnectAll()
        {
            _logger.Information("Disconnecting all...");

            return true;
        }
    }
}