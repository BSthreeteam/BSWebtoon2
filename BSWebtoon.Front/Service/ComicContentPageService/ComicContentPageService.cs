using BSWebtoon.Front.Models.DTO.WorkPage;
using BSWebtoon.Model;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System;
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

        public List<WorkContentDTO> ReadworkContent(int EpId, string userName)
        {

            var memberId = _repository.GetAll<Member>().Where(c => c.AccountName == userName).Select(c => c.MemberId).First();

            var couponSource = _repository.GetAll<Coupon>().Where(p => p.MemberId == memberId);//找出登入會員的所有卷

            var EpSource = _repository.GetAll<Episode>().Where(e => e.EpId == EpId).First();//找出點的那一集的所有資料

            var freeComic = _repository.GetAll<EpContent>().Where(c => EpSource.IsFree == true && c.EpId == EpSource.EpId);//判斷那一集是否免費，並讀出所有內容頁

            var countdownCouponComic = _repository.GetAll<EpContent>().Where(c => EpSource.IsCountdownCoupon == true && c.EpId == EpSource.EpId); //判斷那一集是否是可使用倒數卷，並讀出所有內容頁

            var countdownCoupon = couponSource.Where(p => p.CouponTypeId == (int)CouponType.countdownCoupon && p.ComicId == EpSource.ComicId && p.Quantity == 1).FirstOrDefault();//找出登入者這部漫畫的倒數卷數量是1的

            var readCoupon = couponSource.Where(p => p.CouponTypeId == (int)CouponType.readCoupon && p.ComicId == EpSource.ComicId).OrderByDescending(p => p.CreateTime).FirstOrDefault();//找出登入者這部漫畫的最新閱讀卷

            var universalCoupon = couponSource.Where(p => p.CouponTypeId == (int)CouponType.universalCoupon).OrderByDescending(p => p.CreateTime)
                .FirstOrDefault();//找出登入者這部漫畫的最新通用卷


            if (freeComic != null)
            {
                //免費集
                var result = Read(EpId, EpSource, freeComic); //如是選出那集裡的內容頁等需要的資料

                ViewRecordCreate(EpId, memberId);


                return result;
            }
            else if (countdownCouponComic != null && countdownCoupon.Quantity != 0)
            {
                //倒數卷
                var result = Read(EpId, EpSource, countdownCouponComic); //如果有找到符合條件的倒數卷就找出那集裡的內容頁等需要的資料

                countdownCoupon.Quantity = 0;
                _repository.SaveChange();

                ViewRecordCreate(EpId, memberId);
                CouponUsedRecordCreate(EpId, memberId, countdownCoupon.CouponId);

                return result;

            }
            else if (readCoupon != null && readCoupon.Quantity > 0)
            {
                //閱讀卷
                var workContent = _repository.GetAll<EpContent>();
                var result = Read(EpId, EpSource, workContent); //如是readCouponQuantity有得用就找出那集裡的所有內容頁

                readCoupon.Quantity -= 1;
                _repository.SaveChange();

                ViewRecordCreate(EpId, memberId);
                CouponUsedRecordCreate(EpId, memberId, countdownCoupon.CouponId);



                return result;


            }
            else if (universalCoupon != null && universalCoupon.Quantity > 0)
            {
                //通用卷

                var workContent = _repository.GetAll<EpContent>();
                var result = Read(EpId, EpSource, workContent); //如是universalCouponQuantity有得用就找出那集裡的所有內容頁


                universalCoupon.Quantity -= 1;
                _repository.SaveChange();

                ViewRecordCreate(EpId, memberId);
                CouponUsedRecordCreate(EpId, memberId, countdownCoupon.CouponId);


                return result;


            }
            else
            {
                return null;
            }



        }



        private List<WorkContentDTO> Read(int epId, Episode epSource, IQueryable<EpContent> content)
        {
            var aLLEpSource = _repository.GetAll<Episode>().Where(x => x.AuditType == 1 && x.ComicId == epSource.ComicId).OrderBy(x => x.UploadTime);

            var readResult = content.Select(c => new WorkContentDTO()
            {
                EpId = epId,
                EpTitle = epSource.EpTitle,
                EpContentId = c.EpContentId,
                ImagePath = c.ImagePath,
                Page = c.Page,

                EpList = aLLEpSource.Select(ep => new WorkContentDTO.EpData
                {
                    EpId = ep.EpId,
                    ComicId = ep.ComicId,
                    EpTitle = ep.EpTitle,
                    EpCover = ep.EpCover,
                    UploadTime = ep.UploadTime.ToShortDateString(),
                    IsCountdownCoupon = ep.IsCountdownCoupon,
                    IsFree = ep.IsFree

                }).ToList()
            }).ToList();

            return readResult;

        }

        public void ViewRecordCreate(int EpId, int memberId)
        {
            var viewRecord = new ViewRecord() { MemberId = memberId, EpId = EpId, ViewTime = DateTime.Now, IsDelete = false };//EpContentId要改
            _repository.Create(viewRecord);

            _repository.SaveChange();
        }

        public void CouponUsedRecordCreate(int EpId, int memberId, int CouponId)
        {
            var nowtime = DateTime.UtcNow.AddHours(8);
            var couponused = new CouponUsedRecord() { MemberId = memberId, EpId = EpId, CouponId = CouponId, StartReadTime = nowtime, EndReadTime = nowtime.AddDays(7) };
            _repository.Create(couponused);


            _repository.SaveChange();
        }

    }
}
