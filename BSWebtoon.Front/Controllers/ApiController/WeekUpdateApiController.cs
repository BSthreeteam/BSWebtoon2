using BSWebtoon.Front.Models.ViewModel.WeekUpdate;
using BSWebtoon.Front.Service.WeekUpdateService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BSWebtoon.Front.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeekUpdateApiController : ControllerBase
    {
        private readonly IWeekUpdateService _weekUpdateService;

        public WeekUpdateApiController(IWeekUpdateService weekUpdateService)
        {
            _weekUpdateService = weekUpdateService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var result = _weekUpdateService.ReadNewComic();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok($"錯誤訊息:{ex}");
            }
        }
    }
}
