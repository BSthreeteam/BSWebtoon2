using BSWebtoon.Front.Service.RankService;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}
