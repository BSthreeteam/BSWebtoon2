using BSWebtoon.Front.Models.ViewModel.Search;
using BSWebtoon.Front.Service.SearchService;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BSWebtoon.Front.Controllers
{
    public class SearchController : Controller
    {
        private readonly ISearchService _searchService;
        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
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
        public IActionResult SearchComic(string comicname)
        {
            if (comicname == string.Empty)
            {
                return Content("請輸入你想查詢的相關資訊");
            }
            var searchcomic = _searchService.FindComic(comicname);

            var restult = new SearchViewModel
            {
                SearchList = searchcomic.Select(comic => new SearchViewModel.Search
                {
                    TagName = comic.TagName,
                    ComicName = comic.ComicName,
                    ComicNameImage = comic.ComicNameImage,
                    ComicWeekFigure = comic.ComicWeekFigure,
                    BgCover = comic.BgCover,
                    BannerVideoWeb = comic.BannerVideoWeb,
                    ComicFigure = comic.ComicFigure
                }).ToList()
            };
            //return View(restult);

            return View("SearchResult", restult);
        }
    }
}
