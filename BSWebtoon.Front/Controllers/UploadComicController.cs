using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class UploadComicController : Controller
    {
        //[HttpGet("~/[controller]/[action]/{productId}")]
        public IActionResult UploadComic()
        {
            return View();
        }
    }
}
