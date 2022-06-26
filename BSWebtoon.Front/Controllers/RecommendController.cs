using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class RecommendController : Controller
    {
        public IActionResult Recommend()
        {
            return View();
        }
    }
}
