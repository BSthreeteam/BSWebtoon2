using BSWebtoon.Admin.IDapperRepository;
using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Admin.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IDapperDashActivityRepository _dapperDashActivityRepository;
        private readonly IDapperDashMemberRepository _dapperDashMemberRepository;
        private readonly IDapperDashRankRepository _dapperDashRankRepository;
        private readonly IDapperDashComicRepository _dapperDashComicRepository;
        public DashboardController(IDapperDashActivityRepository dapperDashActivityRepository, 
                                   IDapperDashMemberRepository dapperDashMemberRepository,
                                   IDapperDashRankRepository dapperDashRankRepository,
                                   IDapperDashComicRepository dapperDashComicRepository)
        {
            _dapperDashActivityRepository = dapperDashActivityRepository;
            _dapperDashMemberRepository = dapperDashMemberRepository;
            _dapperDashRankRepository = dapperDashRankRepository;
            _dapperDashComicRepository = dapperDashComicRepository;
        }

        
        public IActionResult Index()
        {

            var activityCount = _dapperDashActivityRepository.SelectAll();
            var memberCount = _dapperDashMemberRepository.SelectAll();
            var rankResult = _dapperDashRankRepository.SelectAll();
            var comicCount = _dapperDashComicRepository.SelectAll();
            return View();
        }
    }
}
