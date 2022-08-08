using BSWebtoon.Front.Models.DTO.FavoriteDTO;
using BSWebtoon.Front.Service.FavoriteService;
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

        public FavoriteApiController(IFavoriteService favoriteService)
        {
            _favoriteService = favoriteService;
        }

        [HttpPost]
        public IActionResult FavoriteRemove([FromBody] RemoveFavoriteInputDTO input)
        {
            var memberId = int.Parse(User.Claims.First(x => x.Type == "MemberID").Value);

            input.MemberId = 3;
            input.ComicIdsToDelete.Add(1);

            try
            {
                _favoriteService.RemoveFavoriteRecord(input);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest();
            }

        }

    }
}
