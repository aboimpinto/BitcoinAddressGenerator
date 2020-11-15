using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Phase0Worker
{
    public class WorkerHostedService : BackgroundService
    {
        private ILogger<WorkerHostedService> _logger;

        public WorkerHostedService(ILoggerFactory loggerFactory)
        {
            this._logger = loggerFactory.CreateLogger<WorkerHostedService>();
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            this._logger.LogDebug("StartAsync...");
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            this._logger.LogDebug("StopAsync...");
            return base.StopAsync(cancellationToken);
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            this._logger.LogDebug("ExecuteAsync...");

            return Task.CompletedTask;
        }
    }
}