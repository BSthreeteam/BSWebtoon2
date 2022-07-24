using BSWebtoon.Front.Models.DTO.Rank;
using BSWebtoon.Front.Models.ViewModels.Rank;
using BSWebtoon.Front.Service.RankService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BSWebtoon.Front.Controllers
{
    public class RankController : Controller
    {
        private readonly IClickRecordService _ClickRecordService;

        public RankController(IClickRecordService clickRecordService)
        {
            _ClickRecordService = clickRecordService;
        }

        public IActionResult Rank() //Rank/Rank 
        {
            //_ClickRecordService.ClickRecordCreate();

            //_ClickRecordService.UpdateRank();
            return View();
        }


        public IActionResult AllRankList() //Rank/AllRankList
        {
            var allrank = _ClickRecordService.ReadAllRank();
            var firstComic = allrank.First();
            var restult = new RankViewModel_ClickRecord
            {
                FirstRank = new RankViewModel_ClickRecord.ClickRecordRank
                {
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
                OtherRank = allrank.Skip(1).Take(99).Select(other => new RankViewModel_ClickRecord.ClickRecordRank
                {
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
            return View(restult);
        }

        public IActionResult RankList(int id) //Rank/RankList 
        {
            var rank = _ClickRecordService.ReadOtherTagRank(id);
            if (rank.Count == 0)
            {
                return View();
            }
            else
            {
                var firstComic = rank.First();
                var restult = new RankViewModel_ClickRecord
                {
                    FirstRank = new RankViewModel_ClickRecord.ClickRecordRank
                    {
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
                return View(restult);
            }
        }

    }
}
