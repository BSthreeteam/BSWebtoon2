using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class RankController : Controller
    {
        public IActionResult Rank()
        {
            return View();
        }
    }
}
