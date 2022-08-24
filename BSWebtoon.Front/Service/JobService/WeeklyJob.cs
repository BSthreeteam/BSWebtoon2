using BSWebtoon.Front.Service.RankService;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using Coravel.Invocable;
using System.Threading.Tasks;
using System.Linq;
using BSWebtoon.Model.Repository.Interface;

namespace BSWebtoon.Front.Service.JobService
{
    public class WeeklyJob : IInvocable
    {
        private readonly IClickRecordService _clickRecordService;
        private readonly BSRepository _repository;
        private readonly IMemoryCacheRepository _iMemoryCacheRepository;

        public WeeklyJob(IClickRecordService clickRecordService, BSRepository repository, IMemoryCacheRepository iMemoryCacheRepository)
        {
            _clickRecordService = clickRecordService;
            _repository = repository;
            _iMemoryCacheRepository = iMemoryCacheRepository;
        }

        public async Task Invoke()
        {
            int refreshDays = 7;
            CacheData("Rank.GetAllRank", _clickRecordService.ReadAllRank(), refreshDays);
            var mainTags = _repository.GetAll<ComicTag>().Where(t => t.IsMainTag == true).Select(t => t.TagId);
            foreach (var tag in mainTags)
            {
                CacheData($"Rank.GetOtherTagRank.{tag}", _clickRecordService.ReadOtherTagRank(tag), refreshDays);
            }
            await Task.CompletedTask;
        }
        public void CacheData<T>(string redisKey, T data, int refreshDays) where T : class
        {
            _iMemoryCacheRepository.Set(redisKey, data, refreshDays);
        }

    }
}
