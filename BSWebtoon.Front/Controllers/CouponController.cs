using BSWebtoon.Front.Service.CouponService;
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
        public IActionResult Coupon() //Coupon/Coupon
        {
            //_couponService.CouponCreate();
            //_couponService.CouponUsedRecordCreate();
            string name = User.Identity.Name;
            _couponService.CouponDataCreate(name, 1,1,1,1);
            return View();
        }
    }
}
