using BSWebtoon.Admin.Models.DTO.AdminUploadDOT;
using BSWebtoon.Admin.Service.AdminUploadService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BSWebtoon.Admin.Controllers
{
    public class AdminUploadComicController : Controller
    {

        private readonly IAdminUploadService _adminUploadService;

        public AdminUploadComicController(IAdminUploadService adminUploadService)
        {
            _adminUploadService = adminUploadService;
        }

        [HttpPost]
        public async Task<IActionResult> AdminUploadComic([FromForm] AdminUploadComicDTO input)
        {


            //呼叫 loginSerice 的 UploadWorkViewUpdateData() 方法 傳入DTO所存放使用者從表單輸入的所有的值，存入一個變數。
            var outputDTO = await _adminUploadService.UploadComicViewUpdateData(input);

            //成敗分支

            if (!outputDTO.IsSuccess)
            {

                return View(input);
            }


            return null;

            //return Content("上傳成功，正在審核中");





        }
    }
}
