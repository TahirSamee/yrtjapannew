using Microsoft.Extensions.Caching.Memory;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using YRTJapan.UI.Services.Interfaces;

namespace YRTJapan.UI.Services
{
    public class CacheService : ICacheService
    {
        private readonly IMemoryCache _memoryCache;

        public CacheService(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        //public async Task<T> GetCachedDataAsync<T>(string cacheKey, Func<Task<T>> fetchData)
        //{
        //    if (!_memoryCache.TryGetValue(cacheKey, out T cachedData))
        //    {
        //        cachedData = await fetchData();
        //        SetCachedData(cacheKey, cachedData, TimeSpan.FromMinutes(60));
        //    }
        //    return cachedData;
        //}
        public async Task<T> GetCachedDataAsync<T>(string cacheKey, Func<Task<T>> fetchData)
        {
            if (!_memoryCache.TryGetValue(cacheKey, out T cachedData))
            {
                cachedData = await fetchData();
                var cacheOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(8)
                };
                _memoryCache.Set(cacheKey, cachedData, cacheOptions);
            }
            return cachedData;
        }

        public void SetCachedData<T>(string cacheKey, T data, TimeSpan? absoluteExpireTime = null, TimeSpan? unusedExpireTime = null)
        {
            var options = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = absoluteExpireTime ?? TimeSpan.FromMinutes(60), // Cache for 60 minutes by default
                SlidingExpiration = unusedExpireTime
            };

            // Store serialized JSON data
            var jsonData = JsonSerializer.Serialize(data);
            _memoryCache.Set(cacheKey, jsonData, options);
        }
    }

}
