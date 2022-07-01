using BSWebtoon.Front.Service.FavoriteService;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class FavoriteController : Controller
    {
        private readonly IFavoriteService _favoriteService;
        private readonly BSRepository _repository;

        public FavoriteController(IFavoriteService favoriteService, BSRepository repository)
        {
            _favoriteService = favoriteService;
            _repository = repository;
        }

        public IActionResult AddFavoriteView()//Favorite/AddFavoriteView
        {
            //_favoriteService.FavoriteCreate();
            return View();
        }
    }
}
