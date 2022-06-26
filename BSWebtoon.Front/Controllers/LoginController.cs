using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
