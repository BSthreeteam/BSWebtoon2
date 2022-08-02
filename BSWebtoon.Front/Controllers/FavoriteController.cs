using BSWebtoon.Front.Models.ViewModel.Favorite;
using BSWebtoon.Front.Service.FavoriteService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BSWebtoon.Front.Controllers
{
    public class FavoriteController : Controller
    {
        private readonly IFavoriteService _favoriteService;
        private readonly FavoriteService _readfavoriteService;

        public FavoriteController(IFavoriteService favoriteService, FavoriteService readfavoriteService)
        {
            _favoriteService = favoriteService;
            _readfavoriteService = readfavoriteService;
        }
        public IActionResult RecordView()//Favorite/RecordView
        {
            return View();
        }
        public IActionResult AddFavoriteView()//Favorite/AddFavoriteView
        {
            //_favoriteService.FavoriteCreate();
            return View();
        }
        public IActionResult RemoveFavoriteView()//Favorite/RemoveFavoriteView
        {
            //找出目前哪個會員登入
            //var userId = int.Parse(User.Identity.Name);
            // 呼叫 Service 存取資料

            var Favorite = _favoriteService.ReadFavorite(3); //userId換3號會員
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

        //public IActionResult RemoveFavoriteView()//Favorite/RemoveFavoriteView
        //{
        //    _favoriteService.FavoriteDelete();
        //    return View();
        //}

        //public IActionResult AddReadFavoriteList()//Favorite/AddReadFavoriteList
        //{

        //    return View(_readfavoriteService.GetFavorite());
        //}
        public IActionResult ReadFavoriteView()
        {
            //找出目前哪個會員登入
            //var userId = int.Parse(User.Identity.Name);
            // 呼叫 Service 存取資料

            var Favorite = _favoriteService.ReadFavorite(3); //userId換3號會員
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
