﻿using BSWebtoon.Front.Models.ViewModel.Recommend;
using BSWebtoon.Front.Service;
using BSWebtoon.Front.Service.RecommendService;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BSWebtoon.Model.Repository.Interface;
using BSWebtoon.Front.Models.DTO.Recommend;

namespace BSWebtoon.Front.Controllers
{
    public class RecommendController : Controller
    {
        private readonly IRecommendService _recommendservice;
        private readonly IMemoryCacheRepository _iMemoryCacheRepository;

        public RecommendController(IRecommendService recommendService, IMemoryCacheRepository iMemoryCacheRepository)
        {
            _recommendservice = recommendService;
            _iMemoryCacheRepository = iMemoryCacheRepository;
        }


        public IActionResult Recommend()
        {
            const string redisKey = "HomePage.GetRecommend";
            var recommendSource = _iMemoryCacheRepository.Get<RecommendDTO>(redisKey);
            //if (recommendSource == null)
            //{
            //    recommendSource = _recommendservice.ReadRecommend();
            //}

            var allRecommend = new List<RecommendViewModel.RecommendComic>() { };
            foreach (var recommend in recommendSource.RecommendComics)
            {
                allRecommend.Add(new RecommendViewModel.RecommendComic
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
                    ActivityImage = recommend.ActivityImage,
                    ControllerName = recommend.ControllerName,
                    ActionName = recommend.ActionName
                });
            }

            var result = new RecommendViewModel() { RecommendComics = allRecommend };

            return View(result);
        }
        public IActionResult HitWork()
        {
            var hitWorkSource = _recommendservice.ReadHitWork();

            var allHitWork = new List<HitWorkViewModel.HitWorkComic>() { };

            foreach (var hitWork in hitWorkSource.HitWorkComics)
            {
                allHitWork.Add(new HitWorkViewModel.HitWorkComic
                {
                    ComicId = hitWork.ComicId,
                    ComicChineseName = hitWork.ComicChineseName,
                    HotComicNameImage = hitWork.HotComicNameImage,
                    HotBgCover = hitWork.HotBgCover,
                    HotVideo = hitWork.HotVideo
                });
            }

            var result = new HitWorkViewModel() { HitWorkComics = allHitWork};

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