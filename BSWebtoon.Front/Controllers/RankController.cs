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
        private readonly ClickRecordService _rankService;

        public RankController(IClickRecordService clickRecordService, ClickRecordService rankService)
        {
            _ClickRecordService = clickRecordService;
            _rankService = rankService;
        }

        public IActionResult Rank() //Rank/Rank 
        {
           //_ClickRecordService.ClickRecordCreate();
           _ClickRecordService.UpdateRank();
            return View();
        }
        public IActionResult RankShowList() //Rank/RankShowList 
        {
            var rank =_ClickRecordService.ReadAllRank();
            var firstRank = rank.First();
            var restult = new RankViewModel_ClickRecord
            {
                //FirstRank = new RankViewModel_ClickRecord.ClickRecordRank
                //{
                //    ClickRecordId = firstRank.ClickRecordId,
                //    ComicName = firstRank.ComicName,
                //    ComicNameImage = firstRank.ComicNameImage,
                //    ComicFigure = firstRank.ComicFigure,
                //    BgCover = firstRank.BgCover,
                //    Introduction = firstRank.Introduction,
                //    BannerVideoWeb = firstRank.BannerVideoWeb
                //},
                OtherRank = rank.Skip(1).Take(99).Select(o => new RankViewModel_ClickRecord.ClickRecordRank
                {
                    ClickRecordId = firstRank.ClickRecordId,
                    ComicName = firstRank.ComicName,
                    ComicNameImage = firstRank.ComicNameImage,
                    ComicFigure = firstRank.ComicFigure,
                    BgCover = firstRank.BgCover,
                    Introduction = firstRank.Introduction,
                    BannerVideoWeb = firstRank.BannerVideoWeb
                }).ToList()

            };
            return View(restult);
        }

    }
}
