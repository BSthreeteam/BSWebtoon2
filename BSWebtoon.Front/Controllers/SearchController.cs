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
        public IActionResult SearchComic()
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
            //var comic = _repository.GetAll<Comic>();
            var searchname = _bSWebtoonContext.Comics.FirstOrDefault(x => x.ComicChineseName == comicname);

            //var searchComic = _repository.GetAll<Comic>();
            //var user = _repository.Users.FirstOrDefault(x => x.Name.ToUpper() == username.ToUpper());
            //return View("SearchResult", user);


            //SELECT*
            //FROM Comic C
            //WHERE C.ComicChineseName = N'小不點皇后'
            return View();
        }
    }
}
