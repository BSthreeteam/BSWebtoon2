﻿using BSWebtoon.Front.Service.FavoriteService;
using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class FavoriteController : Controller
    {
        private readonly IFavoriteService _favoriteService;
        private readonly FavoriteService _readfavoriteService;

        public FavoriteController(IFavoriteService favoriteService, FavoriteService readfavoriteService)
        {
            _favoriteService = favoriteService;
            _readfavoriteService = readfavoriteService;
        }
        public IActionResult RecordView()//Favorite/RecordView
        {
            return View();
        }
        public IActionResult AddFavoriteView()//Favorite/AddFavoriteView
        {
            //_favoriteService.FavoriteCreate();
            return View();
        }
        public IActionResult RemoveFavoriteView()//Favorite/RemoveFavoriteView
        {
            //_favoriteService.FavoriteCreate();
            return View();
        }

        //public IActionResult RemoveFavoriteView()//Favorite/RemoveFavoriteView
        //{
        //    _favoriteService.FavoriteDelete();
        //    return View();
        //}

        //public IActionResult AddReadFavoriteList()//Favorite/AddReadFavoriteList
        //{

        //    return View(_readfavoriteService.GetFavorite());
        //}
    }
}
