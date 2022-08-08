using BSWebtoon.Front.Models.DTO.WorkPage;
using BSWebtoon.Front.Service.FavoriteService;
using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers.ApiController
{
    [Route("/api/[Controller]/[Action]")]
    [ApiController]

    public class FavoriteApiController : Controller
    {
        private readonly IFavoriteService _favoriteService;

        public FavoriteApiController(IFavoriteService favoriteService)
        {
            _favoriteService = favoriteService;
        }

        [HttpPost]

        public IActionResult GetFavoriteData(FavoriteDataDTO favoriteData)
        {
            var data = favoriteData;

            _favoriteService.FavoriteDataCreateOrDelete(data);

            return Ok();
        }
    }
}
