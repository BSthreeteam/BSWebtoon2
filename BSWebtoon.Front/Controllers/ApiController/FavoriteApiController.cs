using BSWebtoon.Front.Models.DTO.FavoriteDTO;
using BSWebtoon.Front.Models.DTO.WorkPage;
using BSWebtoon.Front.Service.FavoriteService;
using BSWebtoon.Front.Service.MemberService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace BSWebtoon.Front.Controllers.ApiController
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FavoriteApiController : ControllerBase
    {
        private readonly IFavoriteService _favoriteService;
        private readonly IMemberService _memberService;

        public FavoriteApiController(IFavoriteService favoriteService, IMemberService memberService)
        {
            _favoriteService = favoriteService;
            _memberService = memberService;
        }

        [HttpPost]
        public IActionResult FavoriteRemove([FromBody] RemoveFavoriteInputDTO input)
        {
            var memberId = _memberService.GetCurrentMemberID();

            input.MemberId = memberId;
            input.ComicIdsToDelete.Add(1);

            try
            {
                _favoriteService.RemoveFavoriteRecord(input);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        public IActionResult GetFavoriteData(FavoriteDataDTO favoriteData)
        {
            var data = favoriteData;

            _favoriteService.FavoriteDataCreateOrDelete(data);

            return Ok();
        }
    }
}
