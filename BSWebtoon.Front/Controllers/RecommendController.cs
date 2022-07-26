using BSWebtoon.Front.Models.ViewModel.Recommend;
using BSWebtoon.Front.Service;
using BSWebtoon.Front.Service.RecommendService;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSWebtoon.Front.Controllers
{
    public class RecommendController : Controller
    {
        private readonly IRecommendService _recommendservice;

        public RecommendController(
            IRecommendService recommendService
            )
        {
            _recommendservice = recommendService;
        }


        public IActionResult Recommend()
        {
            var recommendSource = _recommendservice.ReadRecommend();

            var result = new List<RecommendViewModel>();
            foreach(var recommend in recommendSource)
            {
                result.Add(new RecommendViewModel
                {
                    ComicId = recommend.ComicId,
                    RecommendTag = recommend.RecommendTag,
                    Introduction = recommend.Introduction,
                    Name = recommend.Name,
                    NameImage = recommend.NameImage,
                    ComicBgCover = recommend.ComicBgCover,
                    ActivityBgColor = recommend.ActivityBgColor,
                    BannerVideoWeb = recommend.BannerVideoWeb,
                    ComicFigure = recommend.ComicFigure,
                    ActivityImage = recommend.ActivityImage
                });
            }

            return View(result);
        }
        //public IActionResult ReadClickRecord() //Recommend/ReadClickRecord
        public IActionResult HitWork()
        {
            var hitWorkSource =  _recommendservice.ReadHitWork();

            var result = new List<HitWorkViewModel>();
            foreach(var hitWork in hitWorkSource)
            {
                result.Add(new HitWorkViewModel
                {
                    ComicId = hitWork.ComicId,
                    ComicChineseName = hitWork.ComicChineseName,
                    HotComicNameImage = hitWork.HotComicNameImage,
                    HotBgCover = hitWork.HotBgCover,
                    HotVideo = hitWork.HotVideo
                });
            }

            return View(result);
        }

        public IActionResult AddActivityView() //Recommend/AddActivityView
        {

            //_recommendservice.ActivityCreate();
            return View();
        }

        public IActionResult AddViewRecordView() //Recommend/AddViewRecordView
        {

            //_recommendservice.ViewRecordCreate();
            //_recommendservice.CommentCreate();
            //_recommendservice.CommentLikeCreate();
            //_recommendservice.ReportCreate();
            return View();
        }
        public IActionResult ActivityView() //活動小雞
        {
            //var vr = _recommendservice.ActivityRead();
            return View(/*vr*/);
        }
    }
}