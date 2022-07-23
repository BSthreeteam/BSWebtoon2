using BSWebtoon.Front.Service.ComicService;
using BSWebtoon.Front.Service.ContentPageService;
using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class WorksPageController : Controller
    {
        private readonly IComicService _comicService;
        private readonly IComicContentPageService _comicContentPageService;

        public WorksPageController(IComicService comicService, IComicContentPageService comicContentPageService)
        {
            _comicService = comicService;
            _comicContentPageService = comicContentPageService;
        }

        //public IActionResult WorksPage(int comicId)
        //{
        //    var workPageComic = _comicService.WorkPageRead(comicId);
        //    return View(workPageComic);
        //}


        public IActionResult EpContent(int epId)
        {
            var userName = User.Identity.Name;
            var IsLogin = _comicContentPageService.IsLogin(userName);
            if(IsLogin == null)
            {
                return RedirectToAction();
            }
            else
            {
            var comiccontent = _comicContentPageService.ReadEpContent(epId, userName);
                if(comiccontent != null)
                {
                    return View(comiccontent);

                }
                else
                {
                    return RedirectToAction();
                }

            }
        }
    }
}
