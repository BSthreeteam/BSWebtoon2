using BSWebtoon.Front.Service;
using BSWebtoon.Front.Service.RecommendService;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BSWebtoon.Front.Controllers
{
    public class RecommendController : Controller
    {
        private readonly IRecommendService _recommendservice;
        //private readonly BSRepository _repository;

        private readonly BSRepository _repository;
        public RecommendController(BSRepository repository, IRecommendService recommendService)
        {
            _repository = repository;
            _recommendservice = recommendService;
        }


        public IActionResult Recommend()
        {
            return View();
        }
        public IActionResult AddActivityView() //Recommend/AddActivityView
        {

            _recommendservice.ActivityCreate();
            return View();
        }
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