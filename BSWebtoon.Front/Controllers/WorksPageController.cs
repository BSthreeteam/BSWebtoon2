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

        //public IActionResult WorksPage(int comicId)
        //{
        //    var workPageComic = _comicService.WorkPageRead(comicId);
        //    return View(workPageComic);
        //}
    }
}
