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

        public RecommendController(IRecommendService recommendService)
>>>>>>> CRUD_Kei
            _repository = repository;
        {
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

    }
}