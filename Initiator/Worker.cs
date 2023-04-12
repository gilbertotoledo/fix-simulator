using Microsoft.Extensions.Hosting;
using QuickFix;
using QuickFix.Transport;
using Serilog;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Initiator
{
    public class Worker : BackgroundService
    {
        private readonly ILogger _logger;
        private readonly IApplication _fixApplication;
        private IInitiator _socketInitiator = null;

        public Worker(IApplication fixApplication, ILogger logger)
        {
            _logger = logger;
            _fixApplication = fixApplication;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                return Task.Run(() =>
                {
                    var settings = new SessionSettings("FixConfig/FixConfig.cfg");
                    var storeFactory = new FileStoreFactory(settings);
                    var logFactory = new FileLogFactory(settings);
                    _socketInitiator = new SocketInitiator(_fixApplication, storeFactory, settings, logFactory);

                    _socketInitiator.Start();
                    _logger.Information("Initiator started...");

                }, stoppingToken);
            }
            catch (Exception e)
            {
                _logger.Fatal(e, "Error to run FixApp");
                return Task.CompletedTask;
            }
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            if(_socketInitiator != null && !_socketInitiator.IsStopped)
            {
                _socketInitiator.Stop();
                _logger.Information("Initiator stopped...");
            }

            return base.StopAsync(cancellationToken);
        }
    }
}
