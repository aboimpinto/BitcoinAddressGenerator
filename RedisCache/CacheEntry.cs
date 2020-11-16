namespace RedisCache
{
    public class CacheEntry<TValueType>
    {
        public string Key { get; set; }

        public TValueType Value { get; set; }
    }
}