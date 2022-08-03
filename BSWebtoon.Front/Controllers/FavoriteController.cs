using System.Linq;
using BSWebtoon.Front.Models.ViewModel.ViewRecord;
using BSWebtoon.Front.Service.FavoriteService;
using BSWebtoon.Front.Service.MemberService;
using BSWebtoon.Front.Service.RecordViewService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BSWebtoon.Front.Controllers
{
    public class FavoriteController : Controller
    {
         private readonly IRecordViewService _recordView;

        public FavoriteController(IRecordViewService recordView)
        {
            _recordView = recordView;
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
            //_favoriteService.FavoriteCreate();
            return View();
        }
        public IActionResult RemoveFavoriteView()//Favorite/RemoveFavoriteView
        {
            //_favoriteService.FavoriteCreate();
            return View();
        }

    }
}
