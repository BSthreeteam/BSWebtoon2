using BSWebtoon.Admin.IDapperRepository;
using BSWebtoon.Model;
using BSWebtoon.Model.Models;
using Coravel.Invocable;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BSWebtoon.Admin.Service.JobService
{
    public class CountDownCoupon : IInvocable
    {
        private readonly IDapperCouponUseRecordRepository _dapperCouponUseRecordRepository;
        private readonly IDapperCouponRepository _dapperCouponRepository;

        public CountDownCoupon(IDapperCouponUseRecordRepository dapperCouponUseRecordRepository, IDapperCouponRepository dapperCouponRepository)
        {
            _dapperCouponUseRecordRepository = dapperCouponUseRecordRepository;
            _dapperCouponRepository = dapperCouponRepository;
        }

        public async Task Invoke()
        {
            #region
            // couponRecord 篩選 endTime 
            // coupon 用couponId找couponType 篩選 倒數券
            #endregion
            var coupons = _dapperCouponRepository.SelectAll();
            var coupoonUseRecord = _dapperCouponUseRecordRepository.SelectAll();

            var useRecordFinished = coupoonUseRecord.Where(x => x.EndReadTime < DateTime.Now);

            if (useRecordFinished == null)
            {
                await Task.CompletedTask;
            }
            else
            {
                var couponFinished = coupons.Where(c => 
                useRecordFinished.Any(x => x.CouponId == c.CouponId) && c.CouponTypeId == (int)CouponType.countdownCoupon);

                foreach (var countdownCoupon in couponFinished)
                {
                    countdownCoupon.Quantity = 1;
                    countdownCoupon.CreateTime = DateTime.UtcNow.AddHours(8);
                    _dapperCouponRepository.Update(countdownCoupon);
                }
                await Task.CompletedTask;
            }
        }
    }
}
