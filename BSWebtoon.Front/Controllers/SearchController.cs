using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BSWebtoon.Front.Controllers
{
    public class SearchController : Controller
    {
        private readonly BSRepository _repository;
        private readonly BSWebtoonContext _bSWebtoonContext;
        public SearchController(BSRepository repository, BSWebtoonContext bSWebtoonContext)
        {
            _repository = repository;
            _bSWebtoonContext = bSWebtoonContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SearchComic()//Search/SearchComic
        {
            return View();
        }
        [HttpPost]
        public IActionResult SearchComic(string comicname/*, string tagname*/)//先顯示漫畫名稱在顯示漫畫tag
        {
            if (comicname == string.Empty)
            {
                return Content("請輸入你想查詢的相關資訊");
            }
            var searchcomic = _bSWebtoonContext.Comics.Where(x => x.ComicChineseName.Contains(comicname)).ToList();
            


            return View("SearchResult", searchcomic);
        }
    }
}
