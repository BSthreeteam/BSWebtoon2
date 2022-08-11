using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Admin.Controllers
{
    public class UpdateActivityController : Controller
    {

        //活動編輯
        [HttpGet]
        public IActionResult UpdateActivityData() // /Activity/UpdateActivityData
        {

            return View();
        }

        ////活動編輯
        //[HttpPost]
        //public IActionResult EditActivityData() // /Activity/ActivityData
        //{

        //    return View();
        //}

    }
}
