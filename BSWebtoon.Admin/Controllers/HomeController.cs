using BSWebtoon.Admin.IDapperRepository;
using BSWebtoon.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BSWebtoon.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDapperDashActivityRepository _dapperDashActivityRepository;
        private readonly IDapperDashMemberRepository _dapperDashMemberRepository;
        private readonly IDapperDashRankRepository _dapperDashRankRepository;
        private readonly IDapperDashComicRepository _dapperDashComicRepository;

        private readonly ILogger<HomeController> _logger;

        public HomeController(IDapperDashActivityRepository dapperDashActivityRepository,
                                   IDapperDashMemberRepository dapperDashMemberRepository,
                                   IDapperDashRankRepository dapperDashRankRepository,
                                   IDapperDashComicRepository dapperDashComicRepository,
                                   ILogger<HomeController> logger)
        {
            _dapperDashActivityRepository = dapperDashActivityRepository;
            _dapperDashMemberRepository = dapperDashMemberRepository;
            _dapperDashRankRepository = dapperDashRankRepository;
            _dapperDashComicRepository = dapperDashComicRepository;
            _logger = logger;
        }



        public IActionResult Index()
        {
            var activityCount = _dapperDashActivityRepository.SelectAll();
            var memberCount = _dapperDashMemberRepository.SelectAll();
            var rankResult = _dapperDashRankRepository.SelectAll();
            var comicCount = _dapperDashComicRepository.SelectAll();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
