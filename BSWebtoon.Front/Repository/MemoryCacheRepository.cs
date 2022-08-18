using BSWebtoon.Model.Repository.Interface;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BSWebtoon.Model.Repository
{
    internal class MemoryCacheRepository : IMemoryCacheRepository
    {
        private readonly IDistributedCache _iDistributedCache;

        public MemoryCacheRepository(IDistributedCache iDistributedCache)
        {
            _iDistributedCache = iDistributedCache;
        }

        public void Set<T>(string key, T value, int days) where T : class
        {
            _iDistributedCache.Set(key, ObjectToByteArray(value),
                new DistributedCacheEntryOptions
                {
                    AbsoluteExpiration = DateTimeOffset.Now.AddDays(days).AddMinutes(-1),
                }
            );
        }

        public T Get<T>(string key) where T : class
        {
            return ByteArrayToObject<T>(
                _iDistributedCache.Get(key)
            );
        }

        public void Remove<T>(string key) where T : class
        {
            _iDistributedCache.Remove(key);
        }

        private byte[] ObjectToByteArray<T>(T value) where T : class
        {
            return JsonSerializer.SerializeToUtf8Bytes(value);
        }

        private T ByteArrayToObject<T>(byte[] bytes) where T : class
        {
            return bytes is null ? null : JsonSerializer.Deserialize<T>(bytes);
        }

    }
}
