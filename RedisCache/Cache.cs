using System;
using System.Linq;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace RedisCache
{
    public class Cache : ICache
    {
        private ConnectionMultiplexer _connectionMultiplexer;
        private IDatabase _redisDb;

        public async Task Connect()
        {
            this._connectionMultiplexer = await ConnectionMultiplexer.ConnectAsync("127.0.0.1");
            this._redisDb = this._connectionMultiplexer.GetDatabase(1);
        }

        public async Task<bool> CreateConsumerGroup(string streamName, string consumerGroup)
        {
            if (this._connectionMultiplexer == null || !this._connectionMultiplexer.IsConnected)
            {
                await this.Connect().ConfigureAwait(false);
            }

            try
            {
                var streamInfo = await this._redisDb
                    .StreamInfoAsync(streamName)
                    .ConfigureAwait(false);

                var consumerGroupInfos = await this._redisDb.StreamGroupInfoAsync(streamName);

                if (consumerGroupInfos.Any())
                {
                    return true;
                    // await this._redisDb.StreamDeleteConsumerGroupAsync(streamName, consumerGroup);
                }

                return await this._redisDb.StreamCreateConsumerGroupAsync(
                    streamName, 
                    consumerGroup, 
                    "0-0", 
                    createStream: false);
            }
            catch(System.Exception ex)
            {
                throw new ApplicationException(ex.Message, ex);
            }
        }

        public async Task<string> ReadFromStreamAsync(string streamName, string lastKeyRead = "0-0")
        {
            if (this._connectionMultiplexer == null || !this._connectionMultiplexer.IsConnected)
            {
                await this.Connect().ConfigureAwait(false);
            }

            var value = await this._redisDb
                .StreamRangeAsync(
                    streamName, 
                    minId: "0-0", 
                    maxId: "+", 
                    count: 1, 
                    messageOrder: Order.Descending)
                .ConfigureAwait(false);


            return value.First().Values.First().Value;
        }

        public async Task<CacheEntry<string>> ReadFromStreamGroupAsync(
            string streamName, 
            string streamGroupName, 
            string consumerName, 
            string lastKeyRead = "")
        {
            if (this._connectionMultiplexer == null || !this._connectionMultiplexer.IsConnected)
            {
                await this.Connect().ConfigureAwait(false);
            }

            // list pending messages for the worker
            var values = await this._redisDb
                .StreamReadGroupAsync(
                    streamName, 
                    streamGroupName, 
                    consumerName,
                    "0-0",
                    count: 1)
                .ConfigureAwait(false);
                
            if (!values.Any())
            {
                // get new messages for the worker
                values = await this._redisDb
                .StreamReadGroupAsync(
                    streamName,
                    streamGroupName,
                    consumerName,
                    ">",
                    count: 1)
                .ConfigureAwait(false);
            }

            var returnedValue = new CacheEntry<string>();
            returnedValue.Key = values.Single().Id;
            returnedValue.Value = values.Single().Values.Single().Value;

            return returnedValue;
        }

        public Task WriteToStreamAsync(string streamName, string key, string value)
        {
            throw new System.NotImplementedException();
        }

        public Task AcknowledgeStreamGroupMessageAsync(string stramName, string streamGroupName, string messageId)
        {
            return Task.CompletedTask;
        }
    }
}