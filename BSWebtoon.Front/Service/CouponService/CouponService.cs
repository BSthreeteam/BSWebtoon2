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
                new Coupon(){MemberId=2,ComicId=2,ActivityId=2,CouponTypeId=2,OriginQuantity=6,CreateTime=new DateTime(2022,7,12,8,10,30), Quantity=10 },
                new Coupon(){MemberId=3,ComicId=3,ActivityId=3,CouponTypeId=1,OriginQuantity=4,CreateTime=new DateTime(2022,7,11,8,10,30), Quantity=14 },
                new Coupon(){MemberId=4,ComicId=4,ActivityId=1,CouponTypeId=2,OriginQuantity=6,CreateTime=new DateTime(2022,7,13,8,10,30), Quantity=12 },
                new Coupon(){MemberId=5,ComicId=5,ActivityId=3,CouponTypeId=2,OriginQuantity=6,CreateTime=new DateTime(2022,3,14,8,10,30), Quantity=10 },

                new Coupon(){MemberId=6,ComicId=6,ActivityId=1,CouponTypeId=2,OriginQuantity=2,CreateTime=new DateTime(2022,2,10,8,10,30), Quantity=10 },
                new Coupon(){MemberId=7,ComicId=7,ActivityId=3,CouponTypeId=2,OriginQuantity=3,CreateTime=new DateTime(2022,8,12,8,10,30), Quantity=19 },
                new Coupon(){MemberId=8,ComicId=8,ActivityId=2,CouponTypeId=1,OriginQuantity=6,CreateTime=new DateTime(2022,4,12,8,10,30), Quantity=10 },
                new Coupon(){MemberId=9,ComicId=3,ActivityId=2,CouponTypeId=2,OriginQuantity=7,CreateTime=new DateTime(2022,7,12,8,10,30), Quantity=10 },
                new Coupon(){MemberId=10,ComicId=2,ActivityId=2,CouponTypeId=2,OriginQuantity=6,CreateTime=new DateTime(2022,7,12,8,10,30), Quantity=10 },

                new Coupon(){MemberId=11,ComicId=5,ActivityId=2,CouponTypeId=2,OriginQuantity=3,CreateTime=new DateTime(2022,5,12,8,10,30), Quantity=10 },
                new Coupon(){MemberId=12,ComicId=4,ActivityId=2,CouponTypeId=2,OriginQuantity=2,CreateTime=new DateTime(2022,6,12,8,10,30), Quantity=18 },
                new Coupon(){MemberId=13,ComicId=2,ActivityId=2,CouponTypeId=2,OriginQuantity=6,CreateTime=new DateTime(2022,7,12,8,10,30), Quantity=19 },
                new Coupon(){MemberId=14,ComicId=2,ActivityId=4,CouponTypeId=2,OriginQuantity=4,CreateTime=new DateTime(2022,7,12,8,10,30), Quantity=11 },
                new Coupon(){MemberId=15,ComicId=2,ActivityId=2,CouponTypeId=2,OriginQuantity=6,CreateTime=new DateTime(2022,7,12,8,10,30), Quantity=14 },

                new Coupon(){MemberId=16,ComicId=2,ActivityId=2,CouponTypeId=2,OriginQuantity=6,CreateTime=new DateTime(2022,7,12,8,10,30), Quantity=10 },
                new Coupon(){MemberId=17,ComicId=3,ActivityId=2,CouponTypeId=2,OriginQuantity=6,CreateTime=new DateTime(2022,7,12,8,10,30), Quantity=10 },
                new Coupon(){MemberId=18,ComicId=2,ActivityId=2,CouponTypeId=2,OriginQuantity=6,CreateTime=new DateTime(2022,10,12,8,10,30), Quantity=10 },
                new Coupon(){MemberId=19,ComicId=2,ActivityId=2,CouponTypeId=2,OriginQuantity=8,CreateTime=new DateTime(2022,9,12,8,10,30), Quantity=10 },
                new Coupon(){MemberId=20,ComicId=2,ActivityId=2,CouponTypeId=2,OriginQuantity=7,CreateTime=new DateTime(2022,7,12,8,10,30), Quantity=10 },



            };

            foreach (var coupon in coupons)
            {
                _repository.Create(coupon);
            }

            _repository.SaveChange();
        }

        public void CouponUsedRecordCreate()
        {
            List<CouponUsedRecord> couponuseds = new List<CouponUsedRecord>
            {
                new CouponUsedRecord(){MemberId=1,EpId=1,CouponId=1,StartReadTime=new DateTime(2021,07,22),EndReadTime=new DateTime(2021,07,29)},
                new CouponUsedRecord(){MemberId=1,EpId=2,CouponId=2,StartReadTime=new DateTime(2021,07,23),EndReadTime=new DateTime(2021,07,30)},
                new CouponUsedRecord(){MemberId=1,EpId=1,CouponId=1,StartReadTime=new DateTime(2021,03,22),EndReadTime=new DateTime(2021,03,29)},
                new CouponUsedRecord(){MemberId=4,EpId=5,CouponId=1,StartReadTime=new DateTime(2021,05,22),EndReadTime=new DateTime(2021,05,29)},
                new CouponUsedRecord(){MemberId=3,EpId=1,CouponId=1,StartReadTime=new DateTime(2021,07,22),EndReadTime=new DateTime(2021,07,29)},
                
                new CouponUsedRecord(){MemberId=1,EpId=1,CouponId=1,StartReadTime=new DateTime(2021,07,22),EndReadTime=new DateTime(2021,07,29)},
                new CouponUsedRecord(){MemberId=5,EpId=1,CouponId=1,StartReadTime=new DateTime(2021,03,22),EndReadTime=new DateTime(2021,03,29)},
                new CouponUsedRecord(){MemberId=1,EpId=1,CouponId=1,StartReadTime=new DateTime(2021,04,22),EndReadTime=new DateTime(2021,04,29)},
                new CouponUsedRecord(){MemberId=2,EpId=8,CouponId=1,StartReadTime=new DateTime(2021,01,22),EndReadTime=new DateTime(2021,01,29)},
                new CouponUsedRecord(){MemberId=1,EpId=1,CouponId=1,StartReadTime=new DateTime(2021,07,22),EndReadTime=new DateTime(2021,07,29)},

                new CouponUsedRecord(){MemberId=7,EpId=1,CouponId=1,StartReadTime=new DateTime(2021,07,22),EndReadTime=new DateTime(2021,07,29)},
                new CouponUsedRecord(){MemberId=2,EpId=4,CouponId=1,StartReadTime=new DateTime(2021,02,22),EndReadTime=new DateTime(2021,02,29)},
                new CouponUsedRecord(){MemberId=1,EpId=4,CouponId=1,StartReadTime=new DateTime(2021,06,22),EndReadTime=new DateTime(2021,06,29)},
                new CouponUsedRecord(){MemberId=4,EpId=1,CouponId=1,StartReadTime=new DateTime(2021,01,22),EndReadTime=new DateTime(2021,01,29)},
                new CouponUsedRecord(){MemberId=1,EpId=2,CouponId=1,StartReadTime=new DateTime(2021,07,22),EndReadTime=new DateTime(2021,07,29)},

                new CouponUsedRecord(){MemberId=1,EpId=1,CouponId=1,StartReadTime=new DateTime(2021,07,22),EndReadTime=new DateTime(2021,07,29)},
                new CouponUsedRecord(){MemberId=6,EpId=1,CouponId=1,StartReadTime=new DateTime(2021,01,22),EndReadTime=new DateTime(2021,01,29)},
                new CouponUsedRecord(){MemberId=7,EpId=6,CouponId=1,StartReadTime=new DateTime(2021,05,22),EndReadTime=new DateTime(2021,05,29)},
                new CouponUsedRecord(){MemberId=1,EpId=1,CouponId=1,StartReadTime=new DateTime(2021,01,22),EndReadTime=new DateTime(2021,01,29)},
                new CouponUsedRecord(){MemberId=9,EpId=1,CouponId=1,StartReadTime=new DateTime(2021,03,22),EndReadTime=new DateTime(2021,03,29)},

            };

            foreach (var used in couponuseds)
            {
                _repository.Create(used);
            }

            _repository.SaveChange();
        }
    }
}
