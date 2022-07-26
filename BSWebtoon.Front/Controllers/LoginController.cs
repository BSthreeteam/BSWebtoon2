using BSWebtoon.Front.Service.MemberService;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using static BSWebtoon.Front.Models.DTO.Login.LoginAccountDTO;

namespace BSWebtoon.Front.Controllers
{
    public class LoginController : Controller
    {
        private readonly IMemberService _memberService;

        public LoginController(IMemberService memberService)
        {
            _memberService = memberService;
        }
        public IActionResult AddMemberView()//Login/AddMemberView(我沒有建View，執行了找不到View沒關係，資料還是會進資料庫!!)
        {
            //_memberService.MemberCreate();
            return View();
        }
        public IActionResult AddLoginTypeView() //Login/AddLoginTypeView
        {
            //_memberService.LoginTypeCreate();
            //_memberService.MemberUpdateData();


            return View();
        }
        [HttpGet("~/Login/LoginOption/{scheme}")]
        public IActionResult LoginOption([FromRoute] string scheme)
        {
            //第三方的驗證
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
            var result = await HttpContext.AuthenticateAsync();

            var claims =
            User.Claims.Select(claim => new
            {
                claim.Issuer,//發行者
                claim.OriginalIssuer,
                claim.Type,//提供宣告的語意內容，也就是它指出宣告的用途。
                claim.Value,//顧名思義 質
            });

            var NameIdentifiers = claims.First(x => x.Type == ClaimTypes.NameIdentifier);
            var AccountName = claims.First(x => x.Type == ClaimTypes.Name);
            var Email = claims.First(x => x.Type == ClaimTypes.Email);




            var iutputDTO = new Login3rdInputDTO
            {
                Provider = NameIdentifiers.Issuer.ToLower(),
                NameIdentifier = NameIdentifiers.Value,
                AccountName = AccountName.Value,//用戶名稱
                NickName = AccountName.Value,
                Email = Email.Value,

            };
            await _memberService.LoginAccount(iutputDTO);

            return LocalRedirect("/");
        }
        public IActionResult Logout()
        {
            _memberService.LogoutAccountAsync();
            return Redirect("/");
        }
    }
}
