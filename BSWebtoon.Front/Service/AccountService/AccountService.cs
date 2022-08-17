using BSWebtoon.Front.Models.DTO.Account;
using BSWebtoon.Front.Service.MemberService;
using BSWebtoon.Model;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace BSWebtoon.Front.Service.AccountService
{
    public class AccountService : IAccountService
    {
        private readonly BSRepository _repository;
        private readonly IMemberService _memberService;
        private static string _connectionStr = "Data Source=bswebtoon.database.windows.net;Initial Catalog=BSWebtoonDb;User ID=bs;Password=P@ssword;Encrypt=True;Trusted_Connection=False;MultipleActiveResultSets=true;";

        public AccountService(BSRepository repository, IMemberService memberService)
        {
            _repository = repository;
           _memberService = memberService;
        }

        public AccountInfoDTO GetAccountInfo()
        {
            var memberId = _memberService.GetCurrentMemberID();
            var member = _repository.GetAll<Member>().Where(m => m.MemberId == memberId).First();
            var MemberHaveCoin = decimal.Round(member.Balance, 0);


            var universalCouponQuantity = _repository.GetAll<Coupon>()
                .Where(c => c.MemberId == memberId && c.CouponTypeId == (int)CouponType.universalCoupon)
                .OrderByDescending(c => c.CreateTime).Select(c => c.Quantity).FirstOrDefault();

            int? readCouponQuantity = 0;

            using (SqlConnection conn = new SqlConnection(_connectionStr))
            {
                string sql = $@"SELECT SUM(Quantity) AS ReadCouponQuantity
                                 FROM Coupon
                                 WHERE CreateTime in (
	                                 SELECT 
		                                MAX(CreateTime)
	                                 FROM Coupon
	                                 WHERE MemberId = {memberId}　and CouponTypeId = {(int)CouponType.readCoupon}
	                                 GROUP BY ComicId
                                 )";
                if (conn.Query<int?>(sql).FirstOrDefault() == null)
                {
                    readCouponQuantity = 0;
                }
                else
                {
                    readCouponQuantity = conn.Query<int?>(sql).FirstOrDefault();
                }
            }

            return new AccountInfoDTO()
            {
                MemberId = memberId,
                MemberName = member.AccountName,
                CoinQuantity = MemberHaveCoin,
                UniversalCouponQuantity = universalCouponQuantity,
                ReadCouponQuantity = (int)readCouponQuantity
            };
        }

        public CoinDetailsDTO GetCoinDetails(int memberId)
        {
            var coinRechargeRecord = _repository.GetAll<RechargeRecord>().Where(r => r.MemberId == memberId);

            var addTitle = new CoinDetailsDTO.CoinDetail
            {
                ConsumptionOrRecharge = "儲值/消費",
                CoinContent = "金幣金額",
                CreateTime = "時間",
                ComicName = "漫畫名稱"
            };

            var addcoinRechargeRecord = coinRechargeRecord.Select(x => new CoinDetailsDTO.CoinDetail
            {
                ConsumptionOrRecharge = "儲值",
                CoinContent = x.CashPlanContent.ToString("00."),
                CreateTime = x.CreateTime.Value.AddHours(8).ToString("yyyy/MM/dd HH:mm:ss"),
            }).ToList();

            var coinConsumptionRecord = _repository.GetAll<Coupon>()
                .Where(r => r.MemberId == memberId && r.CouponTypeId == (int)CouponType.readCoupon);

            var addcoinConsumptionRecord = coinConsumptionRecord.Select(x => new CoinDetailsDTO.CoinDetail
            {
                ConsumptionOrRecharge = "消費",
                CoinContent = (x.OriginQuantity * 300m).ToString("00."),
                CreateTime = x.CreateTime.ToString("yyyy/MM/dd HH:mm:ss"),
                ComicName = _repository.GetAll<Comic>().Where(c => c.ComicId == x.ComicId).Select(c => c.ComicChineseName).First()
            }).ToList();

            var allList = new List<CoinDetailsDTO.CoinDetail> { };
            //allList.Add(addTitle);
            allList.AddRange(addcoinRechargeRecord);
            allList.AddRange(addcoinConsumptionRecord);

            allList = allList.OrderByDescending(a => a.CreateTime).ToList();

            return new CoinDetailsDTO() { coinDetailList = allList };
        }

        public CouponDetailsDTO GetCouponDetails(int memberId)
        {
            var buyCouponRecord = _repository.GetAll<Coupon>()
                .Where(c => c.MemberId == memberId)
                .Where(c => c.CouponTypeId == (int)CouponType.readCoupon || c.CouponTypeId == (int)CouponType.universalCoupon);

            var addTitle = new CouponDetailsDTO.CouponDetail
            {
                BuyOrUse = "獲得/使用",
                CouponType = "券種",
                BuyOrUseCount = "獲得/使用數量",
                CreateTime = "時間",
                ComicName = "漫畫名稱",
                ActivityName = "活動名稱"
            };

            var addBuyCouponRecord = buyCouponRecord.Select(x => new CouponDetailsDTO.CouponDetail
            {
                BuyOrUse = x.CouponTypeId == (int)CouponType.readCoupon ? "購買" : "活動贈送",
                CouponType = x.CouponTypeId == (int)CouponType.readCoupon ? "閱讀券" : "通用券",
                BuyOrUseCount = x.OriginQuantity.ToString(),
                CreateTime = x.CreateTime.ToString("yyyy/MM/dd HH:mm:ss"),
                ComicName = _repository.GetAll<Comic>().Where(c => c.ComicId == x.ComicId).Select(c => c.ComicChineseName).First(),
                ActivityName = _repository.GetAll<Activity>().Where(a => a.ActivityId == x.ActivityId).Select(a => a.ActivityName).First(),
            }).ToList();

            var UseCouponRecord = _repository.GetAll<CouponUsedRecord>().Where(u => u.MemberId == memberId);

            var addUseCouponRecord = UseCouponRecord.Select(x => new CouponDetailsDTO.CouponDetail
            {
                BuyOrUse = "使用",
                CouponType = _repository.GetAll<Coupon>().Where(c => c.CouponId == x.CouponId).Select(c => c.CouponTypeId == (int)CouponType.readCoupon ? "閱讀券" : "通用券").First(),
                BuyOrUseCount = "1",
                CreateTime = x.StartReadTime.ToString("yyyy/MM/dd HH:mm:ss"),
                ComicName = _repository.GetAll<Comic>()
                    .Where(c => c.ComicId == _repository.GetAll<Episode>()
                    .Where(e => e.EpId == x.EpId).Select(e => e.ComicId).First())
                    .Select(c => c.ComicChineseName).First(),
            }).ToList();

            var allList = new List<CouponDetailsDTO.CouponDetail> { };
            //allList.Add(addTitle);
            allList.AddRange(addBuyCouponRecord);
            allList.AddRange(addUseCouponRecord);

            allList = allList.OrderByDescending(a => a.CreateTime).ToList();

            return new CouponDetailsDTO { CouponDetailList = allList };
        }

      
    }
}
