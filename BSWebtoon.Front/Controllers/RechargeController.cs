using BSWebtoon.Front.Models.DTO.Price;
using BSWebtoon.Front.Models.ViewModel.CashPlan;
using BSWebtoon.Front.Service.RechargeService;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace BSWebtoon.Front.Controllers
{
    public class RechargeController : Controller
    {
        private readonly BSRepository _repository;

        private readonly IRechargeService _rechargeService;

        public RechargeController(IRechargeService rechargeService, BSRepository repository)
        {
            _rechargeService = rechargeService;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult CashPlanView() //Recharge/CashPlanView
        {
            //_rechargeService.CashPlanCreate();
            var username = User.Identity.Name;
            var allCashPlan = _rechargeService.ReadCashPlan(username);
            var userCashPlan = allCashPlan.First();

            var result = new CashPlanViewModel
            {
                AllCashPlan = allCashPlan.Where(x => x.IsEnable == true).Select(c => new CashPlanViewModel.CashPlanVM
                {
                    CashPlanId = c.CashPlanId,
                    CashPlanContent = c.CashPlanContent,
                    Price = c.Price.ToString("00"),

                }).ToList(),
                Balance = userCashPlan.Balance.ToString("0")
            };
            return View(result);
        }

        //[HttpPost]
        //public IActionResult CashPlan([FromBody] PlanGetRequestDTO request) //Recharge/CashPlan
        //{
        //    var claims =
        //    User.Claims.Select(claim => new
        //    {
        //        claim.Issuer,
        //        claim.OriginalIssuer,
        //        claim.Type,
        //        claim.Value,
        //    }); 
        //    var NameIdentifiers = claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value;
        //    var memberName = _repository.GetAll<Member>().Where(x => x.NameIdentifier == NameIdentifiers).Select(X => X.AccountName);

        //    return Ok();
        //}

        public IActionResult PaymentView() //Recharge/PaymentView
        {
            //_rechargeService.PaymentCreate();
            return View();
        }

        public IActionResult RechargeRecordView() //Recharge/RechargeRecordView
        {
            //_rechargeService.RechargeRecordCreate();
            return View();
        }
    }
}
