using BSWebtoon.Front.Service.ComicService;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BSWebtoon.Front.Controllers
{
    public class ComicController : Controller
    {
        private readonly IComicService _ComicService;
        //private readonly ComicService _comic;
        private readonly BSRepository _repository;
        public ComicController(BSRepository repository, IComicService ComicService/*, ComicService comic*/)
        {
            _ComicService = ComicService;
            _repository = repository;
            //_comic = comic;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddComicTagView() //Comic/AddComicTagView
        {
            _ComicService.ComicTagCreate();
            _ComicService.ComicCreate();
            _ComicService.ComicTagListCreate();
            //_ComicService.ComicTagListUpdate();
            return View();
        }
        public IActionResult AddEpView() //Comic/AddEpView
        {
            _ComicService.EpCreate();
            _ComicService.EpContentCreate();
            _ComicService.EpUpdate();
            return View();
        }
        //public IActionResult WorkPageReadView()//Comic/WorkPageReadView
        //{

        //    return View(_comic.WordPageRead().ToList());
        //}

        //    return View(_comic.WordPageRead().ToList());
        //}

    }
}
