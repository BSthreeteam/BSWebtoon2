using BSWebtoon.Admin.Models.DTO.Activity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BSWebtoon.Admin.Controllers.WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityApiController : ControllerBase
    {
        [HttpPost]
        public IActionResult Index([FromBody] ActivitysInputDTO input)//
        {
            //try
            //{

            //    return Ok();
            //}
            //catch (Exception ex)
            //{
            //    return Ok($"訊息錯誤{ex}");
            //}

            return Ok();
        }
    }
}
