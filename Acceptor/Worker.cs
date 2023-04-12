using Microsoft.Extensions.Hosting;
using QuickFix;
using Serilog;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Acceptor
{
    public class Worker : BackgroundService
    {
        private readonly ILogger _logger;
        private readonly IApplication _fixApplication;
        private IAcceptor _socketAcceptor = null;

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
                    _socketAcceptor = new ThreadedSocketAcceptor(_fixApplication, storeFactory, settings, logFactory);

                    _socketAcceptor.Start();
                    _logger.Information("Acceptor started...");

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
            if (_socketAcceptor != null && !_socketAcceptor.IsLoggedOn)
            {
                _socketAcceptor.Stop();
                _logger.Information("Acceptor stopped...");
            }

            return base.StopAsync(cancellationToken);
        }
    }
}
