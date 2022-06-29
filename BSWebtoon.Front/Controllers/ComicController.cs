using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class ComicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
