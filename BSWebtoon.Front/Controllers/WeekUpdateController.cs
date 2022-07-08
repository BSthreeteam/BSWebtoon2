using BSWebtoon.Front.Models.ViewModels.WeekUpdate;
using BSWebtoon.Front.Service.WeekUpdateService;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace BSWebtoon.Front.Controllers
{
    public class WeekUpdateController : Controller
    {
        private readonly IWeekUpdateService _weekUpdateService;

        public WeekUpdateController(IWeekUpdateService weekUpdateService)
        {
            _weekUpdateService = weekUpdateService;
        }

        //public IActionResult WeekUpdate()
        //{
        //    //var comicData = _weekUpdateService.ReadComic();

        //    //var result = new WeekUpdateViewModel_Page
        //    //{
        //    //    ComicList = comicData.Select(c => new WeekUpdateViewModel_Page.WeekUpdateData
        //    //    {
        //    //        ComicId = c.ComicId
        //    //    })
        //    //};

        //    return View(result);
        //}

        //public  IActionResult WeekUpdateList()
        //{
        //    return View(_weekUpdateService.ReadComic());
        //}

    }
}
