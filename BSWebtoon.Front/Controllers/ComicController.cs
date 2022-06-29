using BSWebtoon.Front.Service.ComicService;
using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class ComicController : Controller
    {
        private readonly IComicService _comicservice;

        public ComicController(IComicService comicService)
        {
            _comicservice = comicService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddEpView() //Comic/AddEpView
        {
            _comicservice.EpCreate();
            return View();
        }

        public IActionResult AddEpContentView() //Comic/AddEpContentView
        {
            _comicservice.EpContentCreate();
            return View();
        }

    }
}
