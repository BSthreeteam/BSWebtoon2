using BSWebtoon.Front.Models.ViewModels.WeekUpdate;
using BSWebtoon.Front.Service.WeekUpdateService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using static BSWebtoon.Front.Models.ViewModels.WeekUpdate.WeekUpdateViewModel;

namespace BSWebtoon.Front.Controllers
{
    public class WeekUpdateController : Controller
    {
        private readonly IWeekUpdateService _weekUpdateService;

        public WeekUpdateController(IWeekUpdateService weekUpdateService)
        {
            _weekUpdateService = weekUpdateService;
        }

        public IActionResult WeekUpdate()
        {
            var weekUpdates = _weekUpdateService.ReadWeekComic();


            var result = new List<WeekUpdateViewModel>();
            foreach (var weekUpdate in weekUpdates)
            {

                var weekComicSoruse = new WeekUpdateViewModel
                {
                    WeekDay = weekUpdate.WeekDay,
                    WeekComicLongList = weekUpdate.WeekUpDateList.Where(c =>c.WeekVideoWrb != null).Select(c => new WeekUpdateViewModel.WeekUpdateDataLing
                    {
                        ComicId = c.ComicId,
                        BgCover = c.BgCover,
                        ComicNameImage = c.ComicNameImage,
                        ComicStatus = c.ComicStatus,
                        UpdateWeek = c.UpdateWeek,
                        WeekVideoWrb = c.WeekVideoWrb

                    }).ToList(),
                    WeekComicList = weekUpdate.WeekUpDateList.Select(c => new WeekUpdateViewModel.WeekUpdateData
                    {
                        ComicId = c.ComicId,
                        BgCover = c.BgCover,
                        ComicNameImage = c.ComicNameImage,
                        ComicStatus = c.ComicStatus,
                        ComicWeekFigure = c.ComicWeekFigure,
                        UpdateWeek = c.UpdateWeek
                    }).ToList()
                    
                };
                result.Add(weekComicSoruse);
            }
            
            return View(result);

        }
    }
}
