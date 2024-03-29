﻿using BSWebtoon.Front.Models.DTO.Rank;
using BSWebtoon.Front.Models.ViewModels.Rank;
using BSWebtoon.Front.Service.RankService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using BSWebtoon.Model.Repository.Interface;

namespace BSWebtoon.Front.Controllers
{
    public class RankController : Controller
    {
        private readonly IClickRecordService _ClickRecordService;
        private readonly IMemoryCacheRepository _iMemoryCacheRepository;

        public RankController(IClickRecordService clickRecordService, IMemoryCacheRepository iMemoryCacheRepository)
        {
            _ClickRecordService = clickRecordService;
            _iMemoryCacheRepository = iMemoryCacheRepository;
        }

        public IActionResult Rank() //Rank/Rank 
        {
            //_ClickRecordService.ClickRecordCreate();

            //_ClickRecordService.UpdateRank();
            return View();
        }


        //[Route("api/[controller]/[action]")]
        public IActionResult AllRankList() //Rank/AllRankList
        {
            const string redisKey = "Rank.GetAllRank";
            var allrank = _iMemoryCacheRepository.Get<List<AllTagRankDTO>>(redisKey);

            //var allrank = _ClickRecordService.ReadAllRank();
            var firstComic = allrank.First();
            var result = new RankViewModel_ClickRecord
            {
                FirstRank = new RankViewModel_ClickRecord.ClickRecordRank
                {
                    TagName = firstComic.TagName,
                    ComicId=firstComic.ComicId,
                    ClickRecordId = firstComic.ClickRecordId,
                    ComicName = firstComic.ComicName,
                    ComicNameImage = firstComic.ComicNameImage,
                    ComicWeekFigure = firstComic.ComicWeekFigure,
                    BgCover = firstComic.BgCover,
                    Introduction = firstComic.Introduction.Substring(0, 40),
                    BannerVideoWeb = firstComic.BannerVideoWeb,
                    ComicFigure = firstComic.ComicFigure
                },
                OtherRank = allrank.Skip(1).Take(99).Select(other => new RankViewModel_ClickRecord.ClickRecordRank
                {
                    TagName = other.TagName,
                    ComicId=other.ComicId,
                    ClickRecordId = other.ClickRecordId,
                    ComicName = other.ComicName,
                    ComicNameImage = other.ComicNameImage,
                    ComicWeekFigure = other.ComicWeekFigure,
                    BgCover = other.BgCover,
                    Introduction = other.Introduction,
                    BannerVideoWeb = other.BannerVideoWeb,
                    Diff = other.Diff
                }).ToList()

            };
            return View(result);
            //return new ObjectResult(result);
        }

        //[Route("api/[controller]/[action]/{id}")]
        public IActionResult RankList(int id) //Rank/RankList 
        {
            string redisKey = $"Rank.GetOtherTagRank.{id}";
            var rank = _iMemoryCacheRepository.Get<List<CategoryRankDTO>>(redisKey);

            //var rank = _ClickRecordService.ReadOtherTagRank(id);
            if (rank.Count == 0)
            {
                var result = new RankViewModel_ClickRecord
                {
                    FirstRank = new RankViewModel_ClickRecord.ClickRecordRank
                    {

                    },
                    OtherRank=new List<RankViewModel_ClickRecord.ClickRecordRank>()
                    {

                    }
                };

                return View(result);
                //return new ObjectResult(result);
            }
            else
            {
                var firstComic = rank.First();
                var result = new RankViewModel_ClickRecord
                {
                    FirstRank = new RankViewModel_ClickRecord.ClickRecordRank
                    {
                        TagId= firstComic.TagId,
                        ClickRecordCount=firstComic.ClickRecordCount,
                        ComicId=firstComic.ComicId,
                        TagName = firstComic.TagName,
                        ClickRecordId = firstComic.ClickRecordId,
                        
                        ComicName = firstComic.ComicName,
                        ComicNameImage = firstComic.ComicNameImage,
                        ComicWeekFigure = firstComic.ComicWeekFigure,
                        BgCover = firstComic.BgCover,
                        Introduction = firstComic.Introduction.Substring(0, 40),
                        BannerVideoWeb = firstComic.BannerVideoWeb,
                        ComicFigure = firstComic.ComicFigure
                    },
                    OtherRank = rank.Skip(1).Take(99).Select(other => new RankViewModel_ClickRecord.ClickRecordRank
                    {
                        TagId=other.TagId,
                        ClickRecordCount=other.ClickRecordCount,
                        ComicId=other.ComicId,
                        TagName = other.TagName,
                        ClickRecordId = other.ClickRecordId,
                        ComicName = other.ComicName,
                        ComicNameImage = other.ComicNameImage,
                        ComicWeekFigure = other.ComicWeekFigure,
                        BgCover = other.BgCover,
                        Introduction = other.Introduction,
                        BannerVideoWeb = other.BannerVideoWeb,
                        Diff = other.Diff
                    }).ToList()


                };
                return View(result);
                //return new ObjectResult(result);
            }
        }


        

    }
}
