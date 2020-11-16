using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RedisCache;

namespace Phase0Worker
{
    public class WorkerHostedService : BackgroundService
    {
        private readonly ICache _cache;
        private ILogger<WorkerHostedService> _logger;

        public WorkerHostedService(
            ICache cache, 
            ILoggerFactory loggerFactory)
        {
            this._logger = loggerFactory.CreateLogger<WorkerHostedService>();
            this._cache = cache;
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

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            this._logger.LogDebug("ExecuteAsync...");
            var workerId = "54a6d489-0c15-4eff-9139-e04cddd163af";
            var streamQueue = "Phase0";
            var streamConsumerGroup = "Phase0ConsumerGroup";

            var groupSuccessfullyCreated = await this._cache.CreateConsumerGroup(streamQueue, streamConsumerGroup);

            while(!stoppingToken.IsCancellationRequested)
            {
                var cacheEntry = await this._cache.ReadFromStreamGroupAsync(
                    streamQueue,
                    streamConsumerGroup,
                    workerId);
            }
        }
    }
}