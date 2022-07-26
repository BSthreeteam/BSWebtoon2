using BSWebtoon.Front.Service.CouponService;
using BSWebtoon.Model;
using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class CouponController : Controller
    {
        private readonly ICouponService _couponService;

        public CouponController(ICouponService couponService)
        {
            _couponService = couponService;
        }
        [HttpPost]
        public IActionResult ActivityCoupon(int Id) //Coupon/Coupon
        {
            //_couponService.CouponCreate();
            //_couponService.CouponUsedRecordCreate();
            string name = User.Identity.Name;
            int couponTypeId = (int)CouponType.universalCoupon;
            int activityId = Id;
            _couponService.GetUniversalCoupon(name, null , activityId, couponTypeId, 1);
            return View();
        }
    }
}
