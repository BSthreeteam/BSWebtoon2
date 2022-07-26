using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("~/api/XX")]
        public IActionResult XX()
        {
            var a = User.Claims;
            return Ok("幹");
        }
    }
}
