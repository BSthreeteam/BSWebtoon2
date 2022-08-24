using BSWebtoon.Front.Service.CouponService;
using BSWebtoon.Front.Service.RecommendService;
using BSWebtoon.Front.Service.WeekUpdateService;
using BSWebtoon.Model.Repository.Interface;
using Coravel.Invocable;
using System.Threading.Tasks;

namespace BSWebtoon.Front.Service.JobService
{
    public class DailyJob : IInvocable
    {
        private readonly IRecommendService _recommendService;
        private readonly IWeekUpdateService _weekUpdateService;
        private readonly IMemoryCacheRepository _iMemoryCacheRepository;
        public DailyJob(IRecommendService recommendService, IWeekUpdateService weekUpdateService, IMemoryCacheRepository iMemoryCacheRepository)
        {
            _recommendService = recommendService;
            _weekUpdateService = weekUpdateService;
            _iMemoryCacheRepository = iMemoryCacheRepository;
        }

        public async Task Invoke()
        {
            int refreshDays = 1;
            CacheData("HomePage.GetRecommend", _recommendService.ReadRecommend(), refreshDays);
            CacheData("Week.GetWeekComic", _weekUpdateService.ReadWeekComic(), refreshDays);
            CacheData("Week.GetNewComic", _weekUpdateService.ReadNewComic(), refreshDays);
            CacheData("Week.GetFinishComic", _weekUpdateService.ReadFinishComic(), refreshDays);

            await Task.CompletedTask;
        }
        public void CacheData<T>(string redisKey,T data,int refreshDays) where T : class
        {
            _iMemoryCacheRepository.Set(redisKey, data, refreshDays);
        }
    }
}
