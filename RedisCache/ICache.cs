using System.Threading.Tasks;

namespace RedisCache
{
    public interface ICache
    {
        Task<bool> CreateConsumerGroup(string stramName, string consumerGroup);

        Task WriteToStreamAsync(string streamName, string key, string value);

        Task<string> ReadFromStreamAsync(string streamName, string lastKeyRead = "");

        Task<CacheEntry<string>> ReadFromStreamGroupAsync(string streamName, 
            string streamGroupName, 
            string consumerName, 
            string lastKeyRead = "");

        Task AcknowledgeStreamGroupMessageAsync(string stramName, string streamGroupName, string messageId);
    }
}
