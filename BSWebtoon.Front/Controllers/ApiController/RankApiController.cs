using BSWebtoon.Front.Models.ViewModels.Rank;
using BSWebtoon.Front.Service.RankService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BSWebtoon.Model.Repository.Interface;
using BSWebtoon.Front.Models.DTO.Rank;

namespace BSWebtoon.Front.Controllers.ApiController
{
    [Route("/api/[controller]/[action]/{id}")]//屬性路由
    [ApiController]
    public class RankApiController : Controller
    {
        private readonly IClickRecordService _ClickRecordService;
        private readonly IMemoryCacheRepository _iMemoryCacheRepository;

        public RankApiController(IClickRecordService clickRecordService, IMemoryCacheRepository iMemoryCacheRepository)
        {
            _ClickRecordService = clickRecordService;
            _iMemoryCacheRepository = iMemoryCacheRepository;
        }
        public IActionResult Index()
        {
            return View();
        }


        //[HttpGet]  /*int id*/
        [HttpGet]
        public IActionResult GetRank(int id)
        {
            try
            {
                if (id == 0)
                {
                    const string redisKey = "Rank.GetAllRank";
                    var result = _iMemoryCacheRepository.Get<List<AllTagRankDTO>>(redisKey);
                    return Ok(result);

                }
                else
                {
                    string redisKey = $"Rank.GetOtherTagRank.{id}";
                    var result = _iMemoryCacheRepository.Get<List<CategoryRankDTO>>(redisKey);
                    return Ok(result);
                }
                //return new ObjectResult(result);

            }
            catch (Exception ex)
            {
                //return new ObjectResult($"錯誤訊息{ex}");
                return Ok($"錯誤訊息{ex}");
            }
        }
    }
}
