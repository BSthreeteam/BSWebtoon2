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
        public RecommendController(BSRepository repository, IRecommendService recommendService)
        {
            _repository = repository;
            recommendService = _recommendservice;
=======
        public RecommendController( IRecommendService recommendService)
        {
            _recommendservice = recommendService;
>>>>>>> c03a10b08a91acca633107483d03ee49586b0654
        }

        //private readonly BSRepository _repository;

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