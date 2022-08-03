using BSWebtoon.Front.Models.ViewModel.WeekUpdate;
using BSWebtoon.Front.Service.WeekUpdateService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BSWebtoon.Front.Controllers
{
    [ApiController]
    [Route("/api/[controller]/[action]")]//最好寫Action因為我們controller可能有很多小雞很複雜，所以加一個Action
    public class WeekUpdateApiController : ControllerBase
    {
        private readonly IWeekUpdateService _weekUpdateService;

        public WeekUpdateApiController(IWeekUpdateService weekUpdateService)
        {
            _weekUpdateService = weekUpdateService;
        }

        [HttpGet]
        public IActionResult GetNewComicAll()
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
