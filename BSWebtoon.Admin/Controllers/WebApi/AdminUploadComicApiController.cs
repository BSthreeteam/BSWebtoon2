using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Admin.Controllers.WebApi
{
    [Route("/api/[controller]/[action]")]
    [ApiController]
    public class AdminUploadComicApiController : ControllerBase
    {
        [HttpPost]
        public IActionResult AdminUploadComic()
        {
            return Ok();
        }
    }
}
