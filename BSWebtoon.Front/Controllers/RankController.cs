using BSWebtoon.Front.Service.RankService;
using BSWebtoon.Front.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
           //_ClickRecordService.UpdateRank();
            return View();
        }

        //public IActionResult RankList() //Rank/RankList 
        //{
        //    _ClickRecordService.ClickRecordCreate();
        //    return View(_rankService.ReadRank());
        //}

    }
}
