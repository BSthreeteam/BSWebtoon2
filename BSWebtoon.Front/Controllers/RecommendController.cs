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
<<<<<<< HEAD
        private readonly BSRepository _repository;
        public RecommendController(BSRepository repository,IRecommendService recommendService)
=======
        //private readonly BSRepository _repository;
        public RecommendController(
            
            IRecommendService recommendService
            )
>>>>>>> 5a2c0bc029fba792253f3e94f1479d16a4fea576
        {
            _recommendservice = recommendService;
            //_repository = repository;
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

    }
}
