using BSWebtoon.Admin.IDapperRepository;
using BSWebtoon.Model;
using BSWebtoon.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BSWebtoon.Admin.Service.CouponSevice
{
    public class CouponService : ICouponService
    {
        private readonly IDapperMemberRepository _dapperMemberRepository; 
        private readonly IDapperComicRepository _dapperComicRepository;
        private readonly IDapperCouponRepository _dapperCouponRepository;

        public CouponService(IDapperMemberRepository dapperMemberRepository, IDapperComicRepository dapperComicRepository, IDapperCouponRepository dapperCouponRepository)
        {
            _dapperMemberRepository = dapperMemberRepository;
            _dapperComicRepository = dapperComicRepository;
            _dapperCouponRepository = dapperCouponRepository;
        }

        public void NewComicGetCountdownCoupon()
        {
            var AllMember = _dapperMemberRepository.SelectAll();
            var AllComic = _dapperComicRepository.SelectAll().Where(c => c.AuditType == (int)AuditType.auditPass);
            var CoundownCoupons = _dapperCouponRepository.SelectAll().Where(c => c.CouponTypeId == (int)CouponType.countdownCoupon);
            var NewComics = AllComic.Where(c => !CoundownCoupons.Any(coupon => coupon.ComicId == c.ComicId));

            List<Coupon> countdowncoupons = new List<Coupon>();
            foreach (var comic in NewComics)
            {
                foreach (var member in AllMember)
                {
                    countdowncoupons.Add(new Coupon()
                    {
                        MemberId = member.MemberId,
                        ComicId = comic.ComicId,
                        CouponTypeId = (int)CouponType.countdownCoupon,
                        OriginQuantity = 1,
                        CreateTime = DateTime.UtcNow.AddHours(8), //台灣時間
                        Quantity = 1
                    });
                }
            }
            foreach (var coupon in countdowncoupons)
            {
                _dapperCouponRepository.Create(coupon);
            }

        }
    }
}
