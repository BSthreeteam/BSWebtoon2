using BSWebtoon.Front.Service.RechargeService;
using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class RechargeController : Controller
    {

        private readonly IRechargeService _rechargeService;

        public RechargeController(IRechargeService rechargeService)
        {
            _rechargeService = rechargeService;
        }

        public IActionResult CashPlanView() //Recharge/CashPlanView
        {
            _rechargeService.CashPlanCreate();
            return View();
        }
        public IActionResult PaymentView() //Recharge/PaymentView
        {
            _rechargeService.PaymentCreate();
            return View();
        }
        public IActionResult RechargeRecordView() //Recharge/RechargeRecordView
        {
            _rechargeService.RechargeRecordCreate();
            return View();
        }
    }
}
