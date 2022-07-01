using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System;
using System.Collections.Generic;

namespace BSWebtoon.Front.Service.CouponService
{
    public class CouponService : ICouponService
    {
        private readonly BSRepository _repository;

        public CouponService(BSRepository repository)
        {
            _repository = repository;
        }

        public void CouponCreate()
        {
            List<Coupon> coupons = new List<Coupon>
            {
                new Coupon(){MemberId=1,ComicId=1,ActivityId=1,CouponTypeId=1,OriginQuantity=5,CreateTime=new DateTime(2022,5,6,6,20,30), Quantity=15 },
                new Coupon(){MemberId=2,ComicId=2,ActivityId=2,CouponTypeId=2,OriginQuantity=6,CreateTime=new DateTime(2022,7,12,8,10,30), Quantity=10 }
            };

            foreach (var coupon in coupons)
            {
                _repository.Create(coupon);
            }

            _repository.SaveChange();
        }
    }
}
