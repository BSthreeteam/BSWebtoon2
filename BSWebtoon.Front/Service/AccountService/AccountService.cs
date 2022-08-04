using BSWebtoon.Front.Models.DTO.Account;
using BSWebtoon.Model;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace BSWebtoon.Front.Service.AccountService
{
    public class AccountService : IAccountService
    {
        private readonly BSRepository _repository;
        private static string _connectionStr = "Data Source=bswebtoon.database.windows.net;Initial Catalog=BSWebtoonDb;User ID=bs;Password=P@ssword;Encrypt=True;Trusted_Connection=False;MultipleActiveResultSets=true;";

        public AccountService(BSRepository repository)
        {
            _repository = repository;
        }

        public AccountInfoDTO GetAccountInfo(int memberId)
        {
            var member = _repository.GetAll<Member>().Where(m => m.MemberId == memberId).First();
            var MemberHaveCoin = decimal.Round(member.Balance, 0);


            var universalCouponQuantity = _repository.GetAll<Coupon>()
                .Where(c => c.MemberId == memberId && c.CouponTypeId == (int)CouponType.universalCoupon)
                .OrderByDescending(c => c.CreateTime).Select(c => c.Quantity).FirstOrDefault();

            var readCouponQuantity = 0;

            using (SqlConnection conn = new SqlConnection(_connectionStr))
            {
                string sql = $@"SELECT SUM(Quantity) AS ReadCouponQuantity
                                 FROM Coupon
                                 WHERE CreateTime in (
	                                 SELECT 
		                                MAX(CreateTime)
	                                 FROM Coupon
	                                 WHERE MemberId = 34　and CouponTypeId = 2
	                                 GROUP BY ComicId
                                 )";
                readCouponQuantity = conn.Query<int>(sql).First();
            }

            return new AccountInfoDTO()
            {
                MemberId = memberId,
                MemberName = member.AccountName,
                CoinQuantity = MemberHaveCoin,
                UniversalCouponQuantity = universalCouponQuantity,
                ReadCouponQuantity = readCouponQuantity
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
                CreateTime = x.CreateTime.Value.ToString("yyyy/MM/dd HH:mm:ss"),
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
            allList.Add(addTitle);
            allList.AddRange(addcoinRechargeRecord);
            allList.AddRange(addcoinConsumptionRecord);

            allList = allList.OrderByDescending(a => a.CreateTime).ToList();

            return new CoinDetailsDTO() { coinDetailList = allList};
        }

        public CouponDetailsDTO GetCouponDetails(int memberId)
        {

            return new CouponDetailsDTO { };
        }
    }
}
