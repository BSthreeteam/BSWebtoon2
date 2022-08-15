using BSWebtoon.Admin.IDapperRepository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BSWebtoon.Model.Models;
//using BSWebtoon.Admin.Models.DTO.Activity;
using BSWebtoon.Admin.Service.ActivityService;
//using BSWebtoon.Admin.Models.ViewModel.Activity;
using System.Threading.Tasks;
using BSWebtoon.Admin.Models.ViewModel.ActivityVM;
using BSWebtoon.Admin.Models.DTO.Activitys;

namespace BSWebtoon.Admin.Controllers
{
    public class ActivityController : Controller
    {
        private readonly IDapperActivityRepository _activityRepository;
        private readonly IActivityService _activityService;

        public ActivityController(IDapperActivityRepository activityRepository, IActivityService activityService)
        {
            _activityRepository = activityRepository;
            _activityService = activityService;
        }

        //活動上傳
        public IActionResult Index() // /Activity/Index
        {

            return View();
        }

        

        //活動上傳
        [HttpGet]
        public IActionResult UpActivityData() // /Activity/UpActivityData
        {
            ////取得員工ID
            //int Employeeid = 17;

            //var EmployeeName = _activityService.GetEmployeeName(Employeeid);
           
            //var EmployeeNameVM = new ActivityViewModel
            //{
            //    EmployeeName = EmployeeName,
            //};
            //return View(EmployeeNameVM);


            var EmployeeName = _activityService.GetAllEmployeeName().WeEmployeeName;

            ViewData["EmployeeName"] = EmployeeName;

            return View();
           

        }
        //活動上傳
        [HttpPost]
        public async Task<IActionResult> UpActivityData([FromForm] ActivityViewModel input) // /Activity/UpActivityData
        {

            var InputDTO = new ActivitysInputDTO
            {
                ActivityName = input.ActivityName,
                ActivityImage = input.ActivityImage,
                ActivityStartTime = input.ActivityStartTime,
                ActivityEndTime = input.ActivityEndTime,    
                ActivityContent = input.ActivityContent,
                ActivityEmployeeName = input.ActivityEmployeeName,
                ActivityBgColor = input.ActivityBgColor,
            };

             await _activityService.UpActivityInfo(InputDTO);


            return RedirectToAction("UpActivityData", "Activity");
        }

        ////活動編輯
        //[HttpGet]
        //public IActionResult EditActivityData() // /Activity/ActivityData
        //{

        //    return View();
        //}
        ////活動編輯
        //[HttpPost]
        //public IActionResult EditActivityData() // /Activity/ActivityData
        //{

        //    return View();
        //}



    }
}
