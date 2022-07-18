using BSWebtoon.Front.Models.DTO.WorkContent;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BSWebtoon.Front.Service.ContentPageService
{
    public class ComicContentPageService : IComicContentPageService
    {
        private readonly BSRepository _repository;

        public ComicContentPageService(BSRepository repository)
        {
            _repository = repository;
        }

        public List<WorkContentDTO> ReadComicContent(int EpId)
        {
            var EpSource = _repository.GetAll<Episode>().Where(c => c.EpId == EpId).First();
            var freeComic = _repository.GetAll<EpContent>().Where(c => EpSource.IsFree == true && c.EpId == EpSource.EpId).Select(c => new WorkContentDTO
            {
                EpId = c.EpId,
                EpContentId = c.EpContentId,
                ImagePath = c.ImagePath,
                Page = c.Page
            });
            var countdownCouponComic = _repository.GetAll<EpContent>().Where(c => EpSource.IsCountdownCoupon == true && c.EpId == EpSource.EpId);
            
            //var freeComic = _repository.GetAll<EpContent>().Where(c => EpSource.IsFree == true && c.EpId == EpSource.EpId).Select(c => new WorkContentDTO
            //{
            //    EpId = c.EpId,
            //    EpContentId = c.EpContentId,
            //    ImagePath = c.ImagePath,
            //    Page = c.Page
            //});

            //var CountdownCouponComic = comicSource.Where(c => c.IsCountdownCoupon == true);





            return null;
        }
    }
}
