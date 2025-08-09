namespace YRTJapan.UI.Services.Interfaces
{
    public interface ICacheService
    {
        Task<T> GetCachedDataAsync<T>(string cacheKey, Func<Task<T>> fetchData);
        void SetCachedData<T>(string cacheKey, T data, TimeSpan? absoluteExpireTime = null, TimeSpan? unusedExpireTime = null);
    }
}
