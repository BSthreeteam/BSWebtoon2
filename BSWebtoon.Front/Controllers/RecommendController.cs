using BSWebtoon.Front.Service;
using BSWebtoon.Front.Service.RecommendService;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BSWebtoon.Front.Controllers
{
    public class RecommendController : Controller
    {
        private readonly IRecommendService _recommendservice;
        private readonly BSWebtoonContext _context;

        //private readonly BSRepository _repository;

        //private readonly BSRepository _repository;
        public RecommendController(BSRepository repository, IRecommendService recommendService, BSWebtoonContext context)
        {
            _recommendservice = recommendService;
        }


        public IActionResult Recommend()
        {

            var recommendSource = _recommendservice.ReadRecommend();
            return View(recommendSource);
        }
        //public IActionResult ReadClickRecord() //Recommend/ReadClickRecord
        public IActionResult HitWork()
        {

            var hitWorkSource =  _recommendservice.ReadHitWork();
            return View(hitWorkSource);
        }

        public IActionResult AddActivityView() //Recommend/AddActivityView
        {

            _recommendservice.ActivityCreate();
            return View();
        }
        //public async Task<IActionResult> ReadActivity() //Recommend/ReadActivity
        //{
        //    //var BSContext = _context.Activity.Include(x => x.PrincipalEmployeeNavigation);
        //    return View(/*await BSContext.ToListAsync()*/);
        //}

        public IActionResult AddViewRecordView() //Recommend/AddViewRecordView
        {

            _recommendservice.ViewRecordCreate();
            _recommendservice.CommentCreate();
            _recommendservice.CommentLikeCreate();
            _recommendservice.ReportCreate();
            return View();
        }
        public IActionResult ActivityView() //活動小雞
        {
            //var vr = _recommendservice.ActivityRead();
            return View(/*vr*/);
        }
    }
}