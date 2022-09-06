using BSWebtoon.Admin.Models.DTO.AdminUploadComicDTO;
using BSWebtoon.Admin.Service.AdminUploadComicService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BSWebtoon.Admin.Controllers.WebApi
{
    [Route("/api/[controller]/[action]")]
    [ApiController]
    public class AdminUploadComicApiController : ControllerBase
    {
        private readonly IAdminUploadComicService _adminUploadComicService;

        public AdminUploadComicApiController(IAdminUploadComicService adminUploadComicService)
        {
            _adminUploadComicService = adminUploadComicService;
        }




        [HttpPost]
        public async Task<IActionResult> AdminUploadComic([FromForm] AdminUploadComicDTO input)
        {

            try
            {
                await _adminUploadComicService.UploadComicViewUpdateData(input);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }


        }
    }
}
