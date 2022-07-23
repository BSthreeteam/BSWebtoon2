using BSWebtoon.Front.Models.DTO.WorkContent;
using BSWebtoon.Model;
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

        public string IsLogin(string userName)
        {
            if (userName == null)
            {
                return null;
            }
            else
            {
                return userName;
            }

        }

        public List<WorkContentDTO> ReadEpContent(int EpId,string useerName)
        {
            var memberId = _repository.GetAll<Member>().Where(c => c.AccountName == useerName).Select(c => c.MemberId).First();
            return ReadContext(EpId, memberId);


        }


        public List<WorkContentDTO> ReadContext(int EpId, int memberId)
        {
            var couponSource = _repository.GetAll<Coupon>().Where(p => p.MemberId == memberId);//找出登入會員的所有卷

            var EpSource = _repository.GetAll<Episode>().Where(e => e.EpId == EpId).First();//找出點的那一集的所有資料

            var freeComic = _repository.GetAll<EpContent>().Where(c => EpSource.IsFree == true && c.EpId == EpSource.EpId);//判斷那一集是否免費，並讀出所有內容頁

            var countdownCouponComic = _repository.GetAll<EpContent>().Where(c => EpSource.IsCountdownCoupon == true && c.EpId == EpSource.EpId); //判斷那一集是否是可使用倒數卷，並讀出所有內容頁
            var countdownCouponQuantity = couponSource.Where(p => p.CouponTypeId == (int)CouponType.倒數免費通用券 && p.ComicId == EpSource.ComicId && p.Quantity == 1).FirstOrDefault();//找出登入者這部漫畫的倒數卷數量是1的

            var readCouponQuantity = couponSource.Where(p => p.CouponTypeId == (int)CouponType.閱讀券 && p.ComicId == EpSource.ComicId).OrderByDescending(p => p.CreateTime)
                .Select(p => p.Quantity).FirstOrDefault();//找出登入者這部漫畫的最新閱讀卷數量

            var universalCouponQuantity = couponSource.Where(p => p.CouponTypeId == (int)CouponType.通用券).OrderByDescending(p => p.CreateTime)
                .Select(p => p.Quantity).FirstOrDefault();//找出登入者這部漫畫的最新通用卷數量


            if (freeComic != null)
            {
            //免費集
                var result = freeComic.Select(c => new WorkContentDTO() {

                    EpId = EpId,
                    EpContentId = c.EpContentId,
                    ImagePath = c.ImagePath,
                    Page = c.Page
                }).ToList(); //如是選出那集裡的內容頁等需要的資料

                return result;
            }
            else if(countdownCouponComic != null && countdownCouponQuantity != null)
            {
                //倒數卷
                var result = countdownCouponComic.Select(c => new WorkContentDTO() {

                    EpId = EpId,
                    EpContentId = c.EpContentId,
                    ImagePath = c.ImagePath,
                    Page = c.Page
                }).ToList(); //如果有找到符合條件的倒數卷就找出那集裡的內容頁等需要的資料

                return result;

            }
            else if (readCouponQuantity != null && readCouponQuantity > 0)
            {
            //閱讀卷
                var readCouponComic = _repository.GetAll<EpContent>().Select(c => new WorkContentDTO() {

                    EpId = EpId,
                    EpContentId = c.EpContentId,
                    ImagePath = c.ImagePath,
                    Page = c.Page
                }).ToList(); //如是readCouponQuantity有得用就找出那集裡的所有內容頁

                return readCouponComic;


            }
            else if(universalCouponQuantity != null && universalCouponQuantity > 0)
            {
            //通用卷
                var comicContent = _repository.GetAll<EpContent>().Select(c => new WorkContentDTO() {

                    EpId = EpId,
                    EpContentId = c.EpContentId,
                    ImagePath = c.ImagePath,
                    Page = c.Page
                }).ToList(); //如是universalCouponQuantity有得用就找出那集裡的所有內容頁

                return comicContent;


            }
            else
            {
                return null;
            }
                    

        }

    }
}
