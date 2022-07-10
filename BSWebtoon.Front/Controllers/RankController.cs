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
           _ClickRecordService.ClickRecordCreate();
           //_ClickRecordService.UpdateRank();
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
                OtherRank = rank.Skip(1).Take(99).Select(other => new RankViewModel_ClickRecord.ClickRecordRank
                {
                    ClickRecordId = other.ClickRecordId,
                    ComicName = other.ComicName,
                    ComicNameImage = other.ComicNameImage,
                    ComicFigure = other.ComicFigure,
                    BgCover = other.BgCover,
                    Introduction = other.Introduction,
                    BannerVideoWeb = other.BannerVideoWeb,
                    Diff=other.Diff
                }).ToList()

            };
            
            return View(restult);
        }

    }
}
