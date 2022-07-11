using BSWebtoon.Front.Models.ViewModels.WeekUpdate;
using BSWebtoon.Front.Service.WeekUpdateService;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


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

            foreach (var weekUpdate in weekUpdates)
            {
                var result = new WeekUpdateViewModel
                {
                    WeekDay = weekUpdate.WeekDay,
                    //WeekComicList = new WeekUpdateViewModel.WeekUpdateData
                    //{

                    //}







                };


            }

            return View();
        }
    }
}
