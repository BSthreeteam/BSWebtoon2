using BSWebtoon.Front.Service.ComicService;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class ComicController : Controller
    {
        private readonly IComicService _ComicService;
        private readonly BSRepository _repository;
        public ComicController(BSRepository repository, IComicService ComicService)
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

        
    }
}
