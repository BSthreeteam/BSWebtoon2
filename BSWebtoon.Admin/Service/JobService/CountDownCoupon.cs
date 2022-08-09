using BSWebtoon.Admin.IDapperRepository;
using BSWebtoon.Model.Models;
using Coravel.Invocable;
using System;
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
            // couponRecord 篩選 endTime 
            // coupon 用couponId找couponType 篩選 倒數券

            var coupons = _dapperCouponRepository.SelectAll();
            var coupoonUseRecord = _dapperCouponUseRecordRepository.SelectAll();

            Console.WriteLine("CountDownCoupon");
            await Task.CompletedTask;
        }
    }
}
