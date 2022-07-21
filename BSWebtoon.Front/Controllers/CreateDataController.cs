using BSWebtoon.Front.Service.ComicService;
using BSWebtoon.Front.Service.CouponService;
using BSWebtoon.Front.Service.EmployeeService;
using BSWebtoon.Front.Service.FavoriteService;
using BSWebtoon.Front.Service.MemberService;
using BSWebtoon.Front.Service.RankService;
using BSWebtoon.Front.Service.RechargeService;
using BSWebtoon.Front.Service.RecommendService;
using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class CreateDataController : Controller
    {
        private readonly IMemberService _memberService;
        private readonly IRechargeService _rechargeService;
        private readonly IEmployeeService _Employeeservice;
        private readonly IComicService _ComicService;
        private readonly IFavoriteService _favoriteService;
        private readonly IClickRecordService _ClickRecordService;
        private readonly IRecommendService _recommendservice;
        private readonly ICouponService _couponService;

        public CreateDataController(IMemberService memberService, IRechargeService rechargeService, IEmployeeService EmployeeService, IComicService ComicService, IFavoriteService favoriteService, IClickRecordService clickRecordService, IRecommendService recommendService, ICouponService couponService)
        {
            _memberService = memberService;
            _rechargeService = rechargeService;
            _Employeeservice = EmployeeService;
            _ComicService = ComicService;
            _favoriteService = favoriteService;
            _ClickRecordService = clickRecordService;
            _recommendservice = recommendService;
            _couponService = couponService;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateData() //CreateData/CreateData 我沒有見View 但是可以進入資料庫
        {
            //_memberService.LoginTypeCreate();
            //_memberService.MemberCreate();
            //_rechargeService.CashPlanCreate();
            //_rechargeService.PaymentCreate();
            //_rechargeService.RechargeRecordCreate();
            //_Employeeservice.EmployeeCreate();
            _ComicService.ComicTagCreate();
            _ComicService.ComicCreate();
            _ComicService.ComicTagListCreate();
            //_ComicService.EpCreate();
            //_ComicService.EpContentCreate();
            //_favoriteService.FavoriteCreate();
            //_ClickRecordService.ClickRecordCreate();
            //_recommendservice.ActivityCreate();
            //_couponService.CouponCreate();
            //_couponService.CouponUsedRecordCreate();
            //_recommendservice.ViewRecordCreate();
            //_recommendservice.CommentCreate();
            //_recommendservice.CommentLikeCreate();
            //_recommendservice.ReportCreate();

            return View();
        }
    }
}
