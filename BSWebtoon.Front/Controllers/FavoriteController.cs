using System.Linq;
using BSWebtoon.Front.Models.ViewModel.ViewRecord;
using BSWebtoon.Front.Models.ViewModel.Favorite;
using BSWebtoon.Front.Service.FavoriteService;
using BSWebtoon.Front.Service.MemberService;
using BSWebtoon.Front.Service.RecordViewService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BSWebtoon.Front.Controllers
{
    public class FavoriteController : Controller
    {
        private readonly IRecordViewService _recordView;
		private readonly IFavoriteService _favoriteService;
		private readonly FavoriteService _readfavoriteService;

		public FavoriteController(IRecordViewService recordView, IFavoriteService favoriteService, FavoriteService readfavoriteService)
        {
            _recordView = recordView;
			_favoriteService = favoriteService;
			_readfavoriteService = readfavoriteService;
		}

        //觀看紀錄
        public IActionResult RecordView()//Favorite/RecordView
        {
            var memberId = int.Parse(User.Claims.First(x => x.Type == "MemberID").Value);
            //將UserId丟入Service
            var allviewcomics = _recordView.ReadRecordView(memberId);

            var restult = new ViewRecordViewModel
            {
                ViewRecordListAll = allviewcomics.Select( comic=> new ViewRecordViewModel.ViewRecordData
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

        [HttpPost]
        public IActionResult FavoriteRemoveComic(string json)//Favorite/RemoveFavoriteView
        {

            //找出目前哪個會員登入
            //var userId = int.Parse(User.Identity.Name);
            // 呼叫 Service 存取資料

            //var Favorite = _favoriteService.ReadFavorite(3); //userId換3號會員
            //var result = new FavoriteViewModel
            //{

            //    FavoriteList = Favorite.Select(f => new FavoriteViewModel.FavoriteData
            //    {
            //        FavoriteId = f.FavoriteId,
            //        MemberId = f.MemberId,
            //        ComicId = f.ComicId,
            //        ComicChineseName = f.ComicChineseName,
            //        ComicEnglishName = f.ComicEnglishName,
            //        ComicNameImage = f.ComicNameImage,
            //        ComicFigure = f.ComicFigure,
            //        BgColor = f.BgColor,
            //        ComicWeekFigure = f.ComicWeekFigure,
            //    }).ToList()
            //};
            var result = "Success";
            return View(result);
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
