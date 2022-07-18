using BSWebtoon.Front.Service.ComicService;
using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class WorksPageController : Controller
    {
        private readonly IComicService _comicService;

        public WorksPageController(IComicService comicService)
        {
            _comicService = comicService;
        }
        [HttpGet]
        public IActionResult WorksPage(int ComicId) //WorksPage/WorksPage/1
        {
            var workPageComic = _comicService.WorkPageRead(ComicId);
            //return View(workPageComic);
            return View();
        }
    }
}
