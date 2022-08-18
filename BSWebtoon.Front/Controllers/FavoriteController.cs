using System.Linq;
using BSWebtoon.Front.Models.ViewModel.ViewRecord;
using BSWebtoon.Front.Models.ViewModel.Favorite;
using BSWebtoon.Front.Service.FavoriteService;
using BSWebtoon.Front.Service.RecordViewService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BSWebtoon.Front.Controllers
{
    public class FavoriteController : Controller
    {
        private readonly IFavoriteService _favoriteService;
        private readonly IRecordViewService _recordView;
        public FavoriteController(IFavoriteService favoriteService, IRecordViewService recordView)
        {
            _favoriteService = favoriteService;
            _recordView = recordView;
        }

        public IActionResult RecordView()//Favorite/RecordView
        {
            //將UserId丟入Service
            var allviewcomics = _recordView.ReadRecordView();

            var restult = new ViewRecordViewModel
            {
                ViewRecordListAll = allviewcomics.Select(comic => new ViewRecordViewModel.ViewRecordData
                {
                    ViewRecorId = comic.ViewRecorId,
                    ComicId = comic.ComicId,
                    BgCover = comic.BgCover,
                    EpTitle = comic.EpTitle,
                    ComicWeekFigure = comic.ComicWeekFigure,
                    ComicNameImage = comic.ComicNameImage
                }).ToList()
            };
            string jsonResult = JsonConvert.SerializeObject(restult);
            ViewData["jsonResult"] = jsonResult;
            return View(restult);
        }

        //觀看紀錄移除
        public IActionResult RemoveRecordView()//Favorite/RemoveRecordView
        {
            //將UserId丟入Service
            var allviewcomics = _recordView.ReadRecordView();

            var restult = new ViewRecordViewModel
            {
                ViewRecordListAll = allviewcomics.Select(comic => new ViewRecordViewModel.ViewRecordData
                {
                    ViewRecorId = comic.ViewRecorId,
                    ComicId = comic.ComicId,
                    BgCover = comic.BgCover,
                    EpTitle = comic.EpTitle,
                    ComicWeekFigure = comic.ComicWeekFigure,
                    ComicNameImage = comic.ComicNameImage
                }).ToList()
            };
            string jsonResult = JsonConvert.SerializeObject(restult);
            ViewData["jsonResult"] = jsonResult;
            return View(restult);
        }

        public IActionResult AddFavoriteView()//Favorite/AddFavoriteView
        {
            return View();
        }

        public IActionResult RemoveFavoriteView()//Favorite/RemoveFavoriteView
        {

            //找出目前哪個會員登入
            //var userId = int.Parse(User.Identity.Name);
            // 呼叫 Service 存取資料

            var Favorite = _favoriteService.ReadFavorite(); //userId換3號會員
            var result = new FavoriteViewModel
            {

                FavoriteList = Favorite.Select(f => new FavoriteViewModel.FavoriteData
                {
                    FavoriteId = f.FavoriteId,
                    MemberId = f.MemberId,
                    ComicId = f.ComicId,
                    ComicChineseName = f.ComicChineseName,
                    ComicEnglishName = f.ComicEnglishName,
                    ComicNameImage = f.ComicNameImage,
                    ComicFigure = f.ComicFigure,
                    BgColor = f.BgColor,
                    ComicWeekFigure = f.ComicWeekFigure,
                }).ToList()
            };
            return View(result);
        }


        [HttpGet]
        public IActionResult FavoriteRemove()
        {

            return View();
        }

        public IActionResult ReadFavoriteView()
        {
            //找出目前哪個會員登入
            //var userId = int.Parse(User.Identity.Name);
            // 呼叫 Service 存取資料

            var Favorite = _favoriteService.ReadFavorite(); //userId換3號會員
            var result = new FavoriteViewModel
            {

                FavoriteList = Favorite.Select(f => new FavoriteViewModel.FavoriteData
                {
                    FavoriteId = f.FavoriteId,
                    MemberId = f.MemberId,
                    ComicId = f.ComicId,
                    ComicChineseName = f.ComicChineseName,
                    ComicEnglishName = f.ComicEnglishName,
                    ComicNameImage = f.ComicNameImage,
                    ComicFigure = f.ComicFigure,
                    BgColor = f.BgColor,
                    ComicWeekFigure = f.ComicWeekFigure,
                }).ToList()
            };
            return View(result);
        }
    }
}
