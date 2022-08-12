using BSWebtoon.Admin.Models.DTO.AdminUploadDTO;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BSWebtoon.Admin.Controllers.WebApi
{
    [Route("/api/[controller]/[action]")]
    [ApiController]
    public class AdminUploadComicApiController : ControllerBase
    {
        [HttpPost]
        public Task<IActionResult> AdminUploadComic([FromForm] AdminUploadComicDTO input)
        {
            return null;
        }
    }
}
