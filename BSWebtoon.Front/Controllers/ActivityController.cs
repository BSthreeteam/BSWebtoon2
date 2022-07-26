using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class ActivityController : Controller
    {
        public IActionResult GiftBox()
        {
            return View();
        }
        public IActionResult ActivityContent()
        {
            return View();
        }
    }
}
