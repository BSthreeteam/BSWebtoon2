using BSWebtoon.Front.Models.DTO.GiftBox;
using BSWebtoon.Front.Service.CouponService;
using BSWebtoon.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Linq;

namespace BSWebtoon.Front.Controllers
{
    [Route("/api/[Controller]/[Action]")]
    [ApiController]
    public class CouponController : Controller
    {
        private readonly ICouponService _couponService;

        public CouponController(ICouponService couponService)
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
