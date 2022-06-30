﻿using BSWebtoon.Front.Service.ComicService;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class ComicController : Controller
    {
        private readonly IComicService _ComicService;
        private readonly BSRepository _repository;
        public ComicController(BSRepository repository, IComicService ComicService)
        {
            _ComicService = ComicService;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddComicTagView() //Comic/AddComicTagView
        {
            _ComicService.ComicTagCreate();
            _ComicService.ComicCreate();
            _ComicService.ComicTagListCreate();
            return View();
        }
        public IActionResult AddEpView() //Comic/AddEpView
        {
            _ComicService.EpCreate();
            return View();
        }

        public IActionResult AddEpContentView() //Comic/AddEpContentView
        {
            _ComicService.EpContentCreate();
            return View();
        }

    }
}
