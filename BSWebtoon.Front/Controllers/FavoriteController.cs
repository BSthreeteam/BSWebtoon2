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


        public IActionResult RecordView()//Favorite/RecordView
        {
            var allviewcomics = _recordView.ReadRecordView();
            var firstComic = allviewcomics.First();

            var restult = new ViewRecordViewModel
            {
                ViewRecordList = new ViewRecordViewModel.ViewRecordData
                {
                    ComicId = firstComic.ComicId,
                    ComicFigure = firstComic.ComicFigure,
                    ComicNameImage = firstComic.ComicNameImage,
                    BgCover = firstComic.BgCover,
                    EpTitle = firstComic.EpTitle
                },
                //All_ViewRecordList = new ViewRecordViewModel.AllViewRecord
                //{
                //    ViewRecorId = ComicRecordViewById[0].ViewRecorId,
                //    ComicId = ComicRecordViewById[0].ComicId,
                //    BgCover = ComicRecordViewById[0].BgCover,
                //    EpTitle = ComicRecordViewById[0].EpTitle,
                //    ComicFigure = ComicRecordViewById[0].ComicFigure,
                //    ComicNameImage = ComicRecordViewById[0].ComicNameImage
                //}
            };

            //string jsonResult = JsonConvert.SerializeObject(allviewcomics);

            //ViewData["jsonResult"] = jsonResult;

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

        //public IActionResult RemoveFavoriteView()//Favorite/RemoveFavoriteView
        //{
        //    _favoriteService.FavoriteDelete();
        //    return View();
        //}
    }
}
