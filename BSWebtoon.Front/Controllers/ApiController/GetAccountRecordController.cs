using BSWebtoon.Front.Models.ViewModel.Account;
using BSWebtoon.Front.Service.AccountService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BSWebtoon.Front.Controllers.ApiController
{
    [Route("api/[Controller]/[Action]")]
    [ApiController]
    public class GetAccountRecordController : Controller
    {
        private readonly IAccountService _accountService;

        public GetAccountRecordController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("{id}")]
        public IActionResult GetCoinDetails(int id)
        {
            var coinDetailsSource = _accountService.GetCoinDetails(id);

            var detailsList = new List<CoinDetailsViewModel.CoinDetail>() { };

            foreach (var coinDetail in coinDetailsSource.coinDetailList)
            {
                detailsList.Add(new CoinDetailsViewModel.CoinDetail()
                {
                    ConsumptionOrRecharge = coinDetail.ConsumptionOrRecharge,
                    CoinContent = coinDetail.CoinContent,
                    CreateTime = coinDetail.CreateTime,
                    ComicName = coinDetail.ComicName,
                });
            }

            var result = new CoinDetailsViewModel() { coinDetailList = detailsList };

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetCouponDetails(int id)
        {
            var couponDetailsSource = _accountService.GetCouponDetails(id);

            var detailsList = new List<CouponDetailsViewModel.CouponDetail>() { };

            foreach (var couponDetail in couponDetailsSource.CouponDetailList)
            {
                detailsList.Add(new CouponDetailsViewModel.CouponDetail()
                {
                    BuyOrUse = couponDetail.BuyOrUse,
                    CouponCount = couponDetail.CouponCount,
                    CreateTime = couponDetail.CreateTime,
                    ComicName = couponDetail.ComicName,
                    ActivityName = couponDetail.ActivityName,
                });
            }

            var result = new CouponDetailsViewModel() { CouponDetailList = detailsList };

            return Ok(result);
        }
    }
}
