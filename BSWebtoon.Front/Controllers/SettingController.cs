using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class SettingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //設定頁面
        //public IActionResult SettingView()
        //{
        //    return View();
        //}
    }
}
