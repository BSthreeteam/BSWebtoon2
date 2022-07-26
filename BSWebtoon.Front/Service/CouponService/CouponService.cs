using BSWebtoon.Model;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

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
                new Coupon(){MemberId=1,ComicId=1,ActivityId=1,CouponTypeId=1,OriginQuantity=1,CreateTime=new DateTime(2022,5,6,6,20,30),    Quantity=15, },
                new Coupon(){MemberId=2,ComicId=2             ,CouponTypeId=2,OriginQuantity=2,CreateTime=new DateTime(2022,7,12,8,10,30),   Quantity=10 },
                new Coupon(){MemberId=3,ComicId=3,ActivityId=3,CouponTypeId=3,OriginQuantity=1,CreateTime=new DateTime(2022,7,11,8,10,30),  Quantity=14 },
                new Coupon(){MemberId=4,ComicId=4,ActivityId=1,CouponTypeId=1,OriginQuantity=1,CreateTime=new DateTime(2022,7,13,8,10,30),   Quantity=12 },
                new Coupon(){MemberId=5,ComicId=5             ,CouponTypeId=2,OriginQuantity=6,CreateTime=new DateTime(2022,3,14,8,10,30),   Quantity=10 },

                new Coupon(){MemberId=6,ComicId=6,ActivityId=1,CouponTypeId=3,OriginQuantity=1,CreateTime=new DateTime(2022,2,10,8,10,30),   Quantity=10 },
                new Coupon(){MemberId=7,ComicId=7             ,CouponTypeId=2,OriginQuantity=3,CreateTime=new DateTime(2022,8,12,8,10,30),   Quantity=19 },
                new Coupon(){MemberId=8,ComicId=8,ActivityId=2,CouponTypeId=1,OriginQuantity=1,CreateTime=new DateTime(2022,4,12,8,10,30),   Quantity=10 },
                new Coupon(){MemberId=9,ComicId=3,ActivityId=2,CouponTypeId=3,OriginQuantity=1,CreateTime=new DateTime(2022,7,12,8,10,30),   Quantity=10 },
                new Coupon(){MemberId=10,ComicId=2             ,CouponTypeId=2,OriginQuantity=6,CreateTime=new DateTime(2022,7,12,8,10,30),  Quantity=10 },

                new Coupon(){MemberId=11,ComicId=5             ,CouponTypeId=2,OriginQuantity=3,CreateTime=new DateTime(2022,5,12,8,10,30),  Quantity=10 },
                new Coupon(){MemberId=12,ComicId=4             ,CouponTypeId=2,OriginQuantity=2,CreateTime=new DateTime(2022,6,12,8,10,30),  Quantity=18 },
                new Coupon(){MemberId=13,ComicId=2,ActivityId=2,CouponTypeId=3,OriginQuantity=1,CreateTime=new DateTime(2022,7,12,8,10,30),  Quantity=19 },
                new Coupon(){MemberId=14,ComicId=3             ,CouponTypeId=2,OriginQuantity=4,CreateTime=new DateTime(2022,7,12,8,10,30),  Quantity=11 },
                new Coupon(){MemberId=15,ComicId=2,ActivityId=2,CouponTypeId=3,OriginQuantity=1,CreateTime=new DateTime(2022,7,12,8,10,30),  Quantity=14 },

                new Coupon(){MemberId=16,ComicId=2,ActivityId=2,CouponTypeId=3,OriginQuantity=1,CreateTime=new DateTime(2022,7,12,8,10,30),  Quantity=10 },
                new Coupon(){MemberId=17,ComicId=4             ,CouponTypeId=2,OriginQuantity=6,CreateTime=new DateTime(2022,7,12,8,10,30),  Quantity=10 },
                new Coupon(){MemberId=18,ComicId=2,ActivityId=2,CouponTypeId=3,OriginQuantity=1,CreateTime=new DateTime(2022,10,12,8,10,30), Quantity=10 },
                new Coupon(){MemberId=19,ComicId=10            ,CouponTypeId=2,OriginQuantity=8,CreateTime=new DateTime(2022,9,12,8,10,30),  Quantity=10 },
                new Coupon(){MemberId=20,ComicId=2,ActivityId=2,CouponTypeId=1,OriginQuantity=1,CreateTime=new DateTime(2022,7,12,8,10,30),  Quantity=10 },
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
                new CouponUsedRecord(){MemberId=1,EpId=1,CouponId=1,StartReadTime=new DateTime(2022,5,6,6,20,30),       EndReadTime=new DateTime(2022,5,13)},
                new CouponUsedRecord(){MemberId=1,EpId=2,CouponId=2,StartReadTime=new DateTime(2022,7,12,8,10,30),      EndReadTime=new DateTime(2022,07,19)},
                new CouponUsedRecord(){MemberId=1,EpId=1,CouponId=1,StartReadTime=new DateTime(2022,7,11,8,10,30),       EndReadTime=new DateTime(2022,07,18)},
                new CouponUsedRecord(){MemberId=4,EpId=5,CouponId=1,StartReadTime=new DateTime(2022,7,13,8,10,30),       EndReadTime=new DateTime(2022,07,20)},
                new CouponUsedRecord(){MemberId=3,EpId=1,CouponId=1,StartReadTime=new DateTime(2022,3,14,8,10,30),       EndReadTime=new DateTime(2022,03,21)},

                new CouponUsedRecord(){MemberId=1,EpId=1,CouponId=1,StartReadTime=new DateTime(2022,2,10,8,10,30),       EndReadTime=new DateTime(2022,2,17)},
                new CouponUsedRecord(){MemberId=5,EpId=1,CouponId=1,StartReadTime=new DateTime(2022,8,12,8,10,30),       EndReadTime=new DateTime(2022,8,19)},
                new CouponUsedRecord(){MemberId=1,EpId=1,CouponId=1,StartReadTime=new DateTime(2022,4,12,8,10,30),       EndReadTime=new DateTime(2022,4,19)},
                new CouponUsedRecord(){MemberId=2,EpId=8,CouponId=1,StartReadTime=new DateTime(2022,7,12,8,10,30),       EndReadTime=new DateTime(2022,7,19)},
                new CouponUsedRecord(){MemberId=1,EpId=1,CouponId=1,StartReadTime=new DateTime(2022,7,12,8,10,30),       EndReadTime=new DateTime(2022,7,19)},

                new CouponUsedRecord(){MemberId=7,EpId=1,CouponId=1,StartReadTime=new DateTime(2022,5,12,8,10,30),       EndReadTime=new DateTime(2022,5,19)},
                new CouponUsedRecord(){MemberId=2,EpId=4,CouponId=1,StartReadTime=new DateTime(2022,6,12,8,10,30),       EndReadTime=new DateTime(2022,6,19)},
                new CouponUsedRecord(){MemberId=1,EpId=4,CouponId=1,StartReadTime=new DateTime(2022,7,12,8,10,30),       EndReadTime=new DateTime(2022,7,19)},
                new CouponUsedRecord(){MemberId=4,EpId=1,CouponId=1,StartReadTime=new DateTime(2022,7,12,8,10,30),       EndReadTime=new DateTime(2022,7,19)},
                new CouponUsedRecord(){MemberId=1,EpId=2,CouponId=1,StartReadTime=new DateTime(2022,7,12,8,10,30),       EndReadTime=new DateTime(2022,7,19)},

                new CouponUsedRecord(){MemberId=1,EpId=1,CouponId=1,StartReadTime=new DateTime(2022,7,12,8,10,30),       EndReadTime=new DateTime(2022,7,19)},
                new CouponUsedRecord(){MemberId=6,EpId=1,CouponId=1,StartReadTime=new DateTime(2022,7,12,8,10,30),       EndReadTime=new DateTime(2022,7,19)},
                new CouponUsedRecord(){MemberId=7,EpId=6,CouponId=1,StartReadTime=new DateTime(2022,10,12,8,10,30),       EndReadTime=new DateTime(2022,10,19)},
                new CouponUsedRecord(){MemberId=1,EpId=1,CouponId=1,StartReadTime=new DateTime(2022,9,12,8,10,30),       EndReadTime=new DateTime(2022,9,19)},
                new CouponUsedRecord(){MemberId=9,EpId=1,CouponId=1,StartReadTime=new DateTime(2022,7,12,8,10,30),       EndReadTime=new DateTime(2022,7,19)},

            };







            //foreach (var a in _repository.GetAll<Member>().Take(2))
            //{
            //    foreach (var b in _repository.GetAll<Episode>())
            //    {
            //        foreach (var c in _repository.GetAll<Coupon>())
            //        {
            //            var t = new CouponUsedRecord() { 
            //                MemberId = a.MemberId, 
            //                EpId = b.EpId, 
            //                CouponId = c.CouponId,
            //                StartReadTime = new DateTime(2022, 5, 6, 6, 20, 30), 
            //                EndReadTime = new DateTime(2022, 5, 13) };

            //            _repository.Create(t);
            //            _repository.SaveChange();
            //        }
            //    }
            //}

            foreach (var used in couponuseds)
            {
                _repository.Create(used);
            }

            _repository.SaveChange();
        }
        /// <summary>
        /// 活動 通用券
        /// </summary>
        public void GetUniversalCoupon(string userName, int? comicId, int activityId, int couponTypeId, int getQuantity)
        {
            //memberId = 1;
            var memberId = _repository.GetAll<Member>().Where(m => m.AccountName == userName).Select(m => m.MemberId).First();
            //comicId = 1;
            //couponTypeId = 1;
            //var couponTest = _repository.GetAll<Coupon>().OrderByDescending(c => c.CreateTime).First();
            var couponQuantity = _repository.GetAll<Coupon>()
                .Where(c => c.MemberId == memberId && c.ComicId == comicId && c.CouponTypeId == couponTypeId)
                .OrderByDescending(c => c.CreateTime).Select(c => c.Quantity).First();

            var coupon = new Coupon()
            {
                MemberId = memberId,
                ComicId = comicId,
                ActivityId = activityId,
                CouponTypeId = couponTypeId,
                OriginQuantity = getQuantity,
                CreateTime = DateTime.UtcNow.AddHours(8),
                Quantity = getQuantity + couponQuantity
            };

            _repository.Create(coupon);
            _repository.SaveChange();
        }

        public void GetCountdownCoupon()
        {
            // 新登入一個會員  將每一部漫畫跑一遍 新增倒數券
            var HaveCoundownCouponMember = _repository.GetAll<Coupon>().Where(c => c.CouponTypeId == (int)CouponType.countdownCoupon);
            var NotHaveCoundownCouponMember = _repository.GetAll<Member>().Where(notHave => HaveCoundownCouponMember.Any(have => have.MemberId == notHave.MemberId));

            var AllComic = _repository.GetAll<Comic>();

            List<Coupon> countdowncoupons = new List<Coupon>();

            foreach (var member in NotHaveCoundownCouponMember)
            {
                foreach (var comic in AllComic)
                {
                    countdowncoupons.Add(new Coupon()
                    {
                        MemberId = member.MemberId,
                        ComicId = comic.ComicId,
                        ActivityId = null,
                        CouponTypeId = (int)CouponType.countdownCoupon,
                        OriginQuantity = 1,
                        CreateTime = DateTime.UtcNow.AddHours(8), //台灣時間
                        Quantity = 1
                    });
                }
            }

            foreach(var coupon in countdowncoupons)
            {
                _repository.Create(coupon);
            }
            _repository.SaveChange();
        }

        public void GetReadCoupon()
        {

        }

    }
}
