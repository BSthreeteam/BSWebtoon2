using BSWebtoon.Front.Service.ComicService;
<<<<<<< HEAD
using BSWebtoon.Model.Repository;
=======
>>>>>>> c03a10b08a91acca633107483d03ee49586b0654
using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class ComicController : Controller
    {
<<<<<<< HEAD
        private readonly IComicService _ComicService;
        private readonly BSRepository _repository;
        public ComicController(BSRepository repository, IComicService ComicService)
=======
        private readonly IComicService _comicservice;

        public ComicController(IComicService comicService)
        {
            _comicservice = comicService;
        }

        public IActionResult Index()
>>>>>>> c03a10b08a91acca633107483d03ee49586b0654
        {
            _ComicService = ComicService;
            _repository = repository;
        }
        public IActionResult AddComicTagView() //Comic/AddComicTagView
        {
            _ComicService.ComicTagCreate();
            _ComicService.ComicCreate();
            _ComicService.ComicTagListCreate();
            return View();
        }
<<<<<<< HEAD

        
=======
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

>>>>>>> c03a10b08a91acca633107483d03ee49586b0654
    }
}
