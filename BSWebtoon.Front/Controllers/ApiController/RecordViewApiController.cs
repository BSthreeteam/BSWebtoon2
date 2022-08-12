using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using BSWebtoon.Front.Service.RecordViewService;
using BSWebtoon.Front.Models.DTO.ViewRecord;

namespace BSWebtoon.Front.Controllers.ApiController
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RecordViewApiController : ControllerBase
    {
        private readonly IRecordViewService _recordViewService;

        public RecordViewApiController(IRecordViewService recordViewService)
        {
            _recordViewService = recordViewService;
        }

        [HttpPost]
        public IActionResult RecordViewRemove([FromBody] RemoveRecordViewInputDTO input)
        {
            var memberId = int.Parse(User.Claims.First(x => x.Type == "MemberID").Value);
            input.MemberId = memberId;
            try
            {
                _recordViewService.ReadRecordViewUpdate(input);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
    }
}
