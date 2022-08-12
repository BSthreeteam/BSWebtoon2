using BSWebtoon.Admin.IDapperRepository;
//using BSWebtoon.Admin.Models.DTO.Activity;
using BSWebtoon.Admin.Service.ActivityService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BSWebtoon.Admin.Controllers.WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateActivityApiController : ControllerBase
    {
        private readonly IDapperActivityRepository _activityRepository;
        private readonly IActivityService _activityService;

        public UpdateActivityApiController(IDapperActivityRepository activityRepository, IActivityService activityService)
        {
            _activityRepository = activityRepository;
            _activityService = activityService;
        }

        
        [HttpGet("Read")]
        public IActionResult ReadActivity()//
        {
            try
            {
                var read_all_activity = _activityRepository.SelectAll();

                return Ok(read_all_activity);
            }
            catch (Exception ex)
            {
                return Ok($"訊息錯誤{ex}");
            }

            
        }


        
        [HttpPost("Update")]
        public IActionResult UpdateActivity(/*[FromBody] ActivitysInputDTO input*/)//
        {
            try
            {

                return Ok();
            }
            catch (Exception ex)
            {
                return Ok($"訊息錯誤{ex}");
            }

            return Ok();
        }
    }
}
