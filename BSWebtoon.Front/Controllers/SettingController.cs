using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class SettingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SettingView()
        {
            return View();
        }
    }
}
