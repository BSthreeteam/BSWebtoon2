using BSWebtoon.Admin.IDapperRepository;
using Coravel.Invocable;
using System.Threading.Tasks;
using System.Linq;

namespace BSWebtoon.Admin.Service.JobService
{
    public class LastFiveEpIsNotCountdown : IInvocable
    {
        private readonly IDapperEpisodeRepository _dapperEpisodeRepository;

        public LastFiveEpIsNotCountdown(IDapperEpisodeRepository dapperEpisodeRepository)
        {
            _dapperEpisodeRepository = dapperEpisodeRepository;
        }

        public async Task Invoke()
        {
            // 排除免費話次 其他話次 找出最新五話 
            // 免費 倒數 都false
            var allEps = _dapperEpisodeRepository.SelectAll();
            var a = allEps.GroupBy(g => g.ComicId);

            foreach (var comic in a)
            {
                // 排除免費 其他所有
                var eps = comic.Where(e => e.IsFree == false);
                foreach (var ep in eps)
                {
                    ep.IsCountdownCoupon = true;
                    _dapperEpisodeRepository.Update(ep);
                }
            }

            foreach (var comic in a)
            {
                // 排除免費 最新五話 
                var newEps = comic.Where(e => e.IsFree == false).OrderByDescending(e => e.UploadTime).Take(5);
                foreach (var ep in newEps)
                {
                    ep.IsCountdownCoupon = false;
                    _dapperEpisodeRepository.Update(ep);
                }
            }

            await Task.CompletedTask;
        }
    }
}
