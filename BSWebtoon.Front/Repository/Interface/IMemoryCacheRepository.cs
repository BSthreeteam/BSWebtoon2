using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSWebtoon.Model.Repository.Interface
{
    public interface IMemoryCacheRepository
    {
        void Set<T>(string key, T value, int days) where T : class;
        void Remove<T>(string key) where T : class;
        T Get<T>(string key) where T : class;

    }
}
