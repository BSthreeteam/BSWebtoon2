using BSWebtoon.Admin.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BSWebtoon.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Login() //Home/Login
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login_check(IFormCollection post) //Home/Login
        {
            bool login_state = false;
            string username = post["exampleInputAccount"]; 
            string password = post["exampleInputPassword"];
            ViewData["msg"] = "";
            ViewData["InputAccount"] = "";
            if (username == "bswebtoon" && password == "BSWEBTOON")
            {
                login_state = true;
            }
            else
            {
                ViewData["InputAccount"] = username;
                if (username == "" && password == "")
                {
                    ViewData["msg"] = "密碼不可空白!";
               
                }
                else
                {
                    ViewData["msg"] = "輸入帳密錯誤!";
            
                }
                login_state = false;

            }


            if (login_state)
            {
                return View("~/Views/Home/index.cshtml");
            }
            else
            {
                return View("~/Views/Home/Login.cshtml");
            }

        }

        public async Task<IActionResult> Logout() //Home/Logout
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
