using BSWebtoon.Front.Service.MemberService;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace BSWebtoon.Front.Controllers
{
    public class LoginController : Controller
    {
        private readonly IMemberService _memberService;
        private readonly BSRepository _repository;

        public LoginController(IMemberService memberService, BSRepository repository)
        {
            _memberService = memberService;
            _repository = repository;
        }
        public IActionResult AddMemberView()//Login/AddMemberView(我沒有建View，執行了找不到View沒關係，資料還是會進資料庫!!)
        {
            _memberService.MemberCreate();
            return View();
        }
        public IActionResult AddLoginTypeView() //Login/AddLoginTypeView
        {
            _memberService.LoginTypeCreate();
            //_memberService.MemberUpdateData();
            return View();
        }
        [HttpGet("~/Login/LoginOption/{scheme}")]
        public IActionResult LoginOption([FromRoute] string scheme)
        {
            //其他第三方的驗證
            var properties = new AuthenticationProperties
            {
                //【驗證】完，要重新導向到的網址
                RedirectUri = Url.Action(nameof(HandleResponse)),
            };
            //用指定的scheme 發起挑戰(=要你去做驗證
            return Challenge(properties, scheme);
        }
        public async Task<IActionResult> HandleResponse() // 挑戰完的 重導到此
        {
            //將 request請求 驗證
            var result = await HttpContext.AuthenticateAsync(
                );


            var claims =
            //result.Principal //驗證結果 裡出現了ClaimsPrincipal聲明主體
            //.Identities.FirstOrDefault()?
            //result.Principal.Claims
            User.Claims.Select(claim => new
            {
                claim.Issuer,
                claim.OriginalIssuer,
                claim.Type,
                claim.Value,
            });

            //用JSON格式觀察測試結果
            return Json(claims);
        }

    }
}
