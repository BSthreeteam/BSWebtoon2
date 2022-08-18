using BSWebtoon.Admin.Models.DTO.Activitys;
using BSWebtoon.Admin.Models.ViewModel.ActivityVM;
using BSWebtoon.Admin.Service.ActivityService;
using BSWebtoon.Admin.Service.CloudinaryService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BSWebtoon.Admin.Controllers
{
    public class UpdateActivityController : Controller
    {

        private readonly IActivityService _activityService;
        private readonly ICloudinaryService _cloudinaryService;
        
        public UpdateActivityController(IActivityService activityService, ICloudinaryService cloudinaryService)
        {
            _activityService = activityService;
            _cloudinaryService = cloudinaryService;
        }

        //活動編輯
        [HttpGet]
        public IActionResult UpdateActivityData() // /Activity/UpdateActivityData
        {

            return View();
        }

        //活動編輯
        [HttpPost]
        public async Task<IActionResult> UpdateActivityData([FromForm] UpdateActivityViewModel input) // /Activity/ActivityData
        {

            var InputDTO = new UpdateActivityInputDTO
            {
                ActivityId = int.Parse(input.ActivityId),
                ActivityName = input.ActivityName,
                ActivityImage = input.ActivityImage,
                ActivityStartTime = input.ActivityStartTime,
                ActivityEndTime = input.ActivityEndTime,
                ActivityContent = input.ActivityContent,
                ActivityBgColor = input.ActivityBgColor,
                
            };
            //if(InputDTO.ActivityImage != null)
            //{
            //    //圖床轉換
            //    var ActivityImageOutput = await _cloudinaryService.UploadAsync(InputDTO.ActivityImage);
            //}


            await _activityService.EidtActivityInfo(InputDTO);

            //傳上傳成功訊息給View
            TempData["EidtActivitySuccess"] = "修改成功!";

            return RedirectToAction("UpdateActivityData", "UpdateActivity");
        }

    }
}
