using BSWebtoon.Front.Models.DTO.GiftBox;
using BSWebtoon.Front.Service.CouponService;
using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers.ApiController
{
    [Route("/api/[Controller]/[Action]")]
    [ApiController]

    public class CouponApiController : Controller
    {
        private readonly ICouponService _couponService;

        public CouponApiController(ICouponService couponService)
        {
            _couponService = couponService;
        }

        [HttpPost]
        public IActionResult ActivityCoupon(GetActivityCouponDTO universalCoupon) //Coupon/Coupon
        {
            var coupon = universalCoupon;
            _couponService.GetUniversalCoupon(coupon);

            return Ok();
        }

        [HttpPost]
        public IActionResult ReadCoupon(GetReadCouponDTO readCoupon)
        {
            var coupon = readCoupon;
            _couponService.GetReadCoupon(coupon);
            return Ok();
        }
    }
}
