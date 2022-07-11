using BSWebtoon.Front.Models.ViewModels.WeekUpdate;
using BSWebtoon.Front.Service.WeekUpdateService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using static BSWebtoon.Front.Models.ViewModels.WeekUpdate.WeekUpdateViewModel;

//namespace BSWebtoon.Front.Controllers
//{
//    public class WeekUpdateController : Controller
//    {
//        //private readonly IWeekUpdateService _weekUpdateService;

//        //public WeekUpdateController(IWeekUpdateService weekUpdateService)
//        //{
//        //    _weekUpdateService = weekUpdateService;
//        //}

        public IActionResult WeekUpdate()
        {
            var weekUpdates = _weekUpdateService.ReadWeekComic();


            var result = new List<WeekUpdateViewModel>();
            foreach (var weekUpdate in weekUpdates)
            {

                var weekComicSoruse = new WeekUpdateViewModel
                {
                    WeekDay = weekUpdate.WeekDay,
                    WeekComicList = weekUpdate.WeekUpDateList.Select(x => new WeekUpdateViewModel.WeekUpdateData
                    {
                        ComicId = x.ComicId,
                        BgCover = x.BgCover,
                        ComicNameImage = x.ComicNameImage,
                        ComicStatus = x.ComicStatus,
                        ComicWeekFigure = x.ComicWeekFigure,
                        UpdateWeek = x.UpdateWeek,
                        WeekVideoWrb = x.WeekVideoWrb
                    }).ToList()
                    
                };
                result.Add(weekComicSoruse);
            }
            
            return View(result);

        }
    }
}
