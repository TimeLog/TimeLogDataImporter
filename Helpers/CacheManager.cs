using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.Extensions.Caching.Memory;

namespace TimeLog.DataImporter.Helpers
{
    public class CacheManager
    {
        private static readonly Lazy<MemoryCache> _cache = new Lazy<MemoryCache>(() =>
        new MemoryCache(new MemoryCacheOptions()));

        private static MemoryCache Cache => _cache.Value;

        public static T GetOrCreate<T>(string key, Func<T> createItem, TimeSpan? expirationTime = null)
        {
            if (!Cache.TryGetValue(key, out T cacheEntry))
            {
                cacheEntry = createItem();

                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(expirationTime ?? TimeSpan.FromMinutes(10))
                    .SetPriority(CacheItemPriority.Normal);

                Cache.Set(key, cacheEntry, cacheEntryOptions);
            }

            return cacheEntry;
        }

        public static void Remove(string key)
        {
            Cache.Remove(key);
        }

        public static void Clear()
        {
            var coherentState = typeof(MemoryCache).GetField("_coherentState",
                BindingFlags.NonPublic | BindingFlags.Instance);

            var entries = coherentState.GetValue(Cache);
            var clearMethod = entries.GetType().GetMethod("Clear",
                BindingFlags.NonPublic | BindingFlags.Instance);

            clearMethod.Invoke(entries, null);
        }
    }
}
