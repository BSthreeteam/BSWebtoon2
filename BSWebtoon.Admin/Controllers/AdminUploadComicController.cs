using BSWebtoon.Admin.Models.DTO.AdminUploadComicDTO;
using BSWebtoon.Admin.Service.AdminUploadComicService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BSWebtoon.Admin.Controllers
{
    public class AdminUploadComicController : Controller
    {


        [HttpGet]
        public IActionResult AdminUploadComic()
        {

            return View();
        }


    }
}
