using BSWebtoon.Front.Service.CouponService;
using BSWebtoon.Front.Service.RecommendService;
using BSWebtoon.Front.Service.WeekUpdateService;
using Coravel.Invocable;
using System.Threading.Tasks;

namespace BSWebtoon.Front.Service.JobService
{
    public class DailyJob : IInvocable
    {
        private readonly IRecommendService _recommendService;
        private readonly IWeekUpdateService _weekUpdateService;
        public DailyJob(IRecommendService recommendService, IWeekUpdateService weekUpdateService)
        {
            _recommendService = recommendService;
            _weekUpdateService = weekUpdateService;
        }

        public async Task Invoke()
        {
            _recommendService.ReadRecommend();
            _weekUpdateService.ReadWeekComic();
            _weekUpdateService.ReadNewComic();
            _weekUpdateService.ReadFinishComic();

            await Task.CompletedTask;
        }
    }
}
