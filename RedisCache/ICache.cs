using System.Threading.Tasks;

namespace RedisCache
{
    public interface ICache
    {
        Task WriteToStreamAsync(string streamName, string key, string value);

        Task<string> ReadFromStreamAsync(string streamName, string lastKeyRead = "");
    }
}
