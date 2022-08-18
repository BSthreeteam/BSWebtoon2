using BSWebtoon.Front.Service.RankService;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using Coravel.Invocable;
using System.Threading.Tasks;
using System.Linq;

namespace BSWebtoon.Front.Service.JobService
{
    public class WeeklyJob : IInvocable
    {
        private readonly IClickRecordService _clickRecordService;
        private readonly BSRepository _repository;


        public WeeklyJob(IClickRecordService clickRecordService, BSRepository repository)
        {
            _clickRecordService = clickRecordService;
            _repository = repository;
        }

        public async Task Invoke()
        {
            _clickRecordService.ReadAllRank();
            var mainTags = _repository.GetAll<ComicTag>().Where(t => t.IsMainTag == true).Select(t => t.TagId);
            foreach (var tag in mainTags)
            {
                _clickRecordService.ReadOtherTagRank(tag);
            }
            await Task.CompletedTask;
        }
    }
}
