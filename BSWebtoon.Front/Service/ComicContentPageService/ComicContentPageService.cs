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

        public List<WorkContentDTO> ReadComicContent(int EpId,string useerName)
        {
            if(useerName == null){
                return null;
            }
            else
            {
                var memberName = _repository.GetAll<Member>().Where(c => c.AccountName == useerName).Select(c => c.MemberId).First();
                ReadContext(EpId, memberName);
            }




            return null;
        }

        public void ReadContext(int EpId,int memberName)
        {
            var couponSource = _repository.GetAll<Coupon>().Where(c => c.MemberId == memberName);
            var EpSource = _repository.GetAll<Episode>().Where(c => c.EpId == EpId).First();
            var freeComic = _repository.GetAll<EpContent>().Where(c => EpSource.IsFree == true && c.EpId == EpSource.EpId).Select(c => new WorkContentDTO
            {
                EpId = c.EpId,
                EpContentId = c.EpContentId,
                ImagePath = c.ImagePath,
                Page = c.Page
            });

            
            var countdownCouponComic = _repository.GetAll<EpContent>().Where(c => EpSource.IsCountdownCoupon == true && c.EpId == EpSource.EpId);

            //var Iscoupon = _repository.GetAll<Coupon>().Where(c => c)



        }

        public enum coupontype
        {
            通用卷,
            閱讀卷,
            倒數卷
        }
    }
}
