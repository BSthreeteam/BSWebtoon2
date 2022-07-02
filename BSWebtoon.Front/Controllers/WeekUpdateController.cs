using BSWebtoon.Front.Service.WeekUpdateService;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult WeekUpdate()
        {
            return View();
        }

        public  IActionResult WeekUpdateList()
        {
            return View(_weekUpdateService.ReadComic());
        }

    }
}
