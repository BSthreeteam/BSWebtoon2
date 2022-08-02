using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers.ApiController
{
    [Route("api/[Controller]/[Action]")]
    [ApiController]
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult AccountInfo()
        {
            return View();
        }
    }
}
