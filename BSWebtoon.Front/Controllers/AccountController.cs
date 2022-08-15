using BSWebtoon.Front.Models.ViewModel.Account;
using BSWebtoon.Front.Service.AccountService;
using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IActionResult AccountInfo()
        {
            var accountSource = _accountService.GetAccountInfo();

            var result = new AccountInfoViewModel()
            {
                MemberId = accountSource.MemberId,
                MemberName = accountSource.MemberName,
                CoinQuantity = accountSource.CoinQuantity,
                UniversalCouponQuantity = accountSource.UniversalCouponQuantity,
                ReadCouponQuantity = accountSource.ReadCouponQuantity,
            };

            return View(result);
        }
    }
}
