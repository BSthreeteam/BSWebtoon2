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

        private readonly BSRepository _repository;
        public RecommendController(BSRepository repository, IRecommendService recommendService, BSWebtoonContext context)
        {
            _recommendservice = recommendService;
            _context = context;
        }


        public IActionResult Recommend()
        {
            return View();
        }
        //public async Task<IActionResult> ReadClickRecord() //Recommend/ReadClickRecord
        //{
        //    //var BSContext = _context.Comic.Include(x => x.AuditEmployee);
        //    //return View(await BSContext.ToListAsync());
        //    //var BSContext = _repository.GetAll<ClickRecord>().GroupBy(c => c.ComicId).ToListAsync();
        //    //foreach (var item in BSContext)
        //    //{
        //    //    var result = item.Count();
        //    //}
        //    var ClickCount = await _recommendservice.ClickCount();

        //    return View(ClickCount);
        //}

        public IActionResult AddActivityView() //Recommend/AddActivityView
        {

            _recommendservice.ActivityCreate();
            return View();
        }
        //public async Task<IActionResult> ReadActivity() //Recommend/ReadActivity
        //{
        //    var BSContext = _context.Activity.Include(x => x.PrincipalEmployeeNavigation);
        //    return View(await BSContext.ToListAsync());
        //}

        public IActionResult AddViewRecordView() //Recommend/AddViewRecordView
        {

            _recommendservice.ViewRecordCreate();
            _recommendservice.CommentCreate();
            _recommendservice.LikeCreate();
            _recommendservice.ReportCreate();
            return View();
        }
    }
}