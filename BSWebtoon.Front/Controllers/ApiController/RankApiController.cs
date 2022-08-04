using BSWebtoon.Front.Models.ViewModels.Rank;
using BSWebtoon.Front.Service.RankService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSWebtoon.Front.Controllers
{
    [Route("/api/[controller]/[action]/{id}")]//屬性路由
    [ApiController]
    public class RankApiController : Controller
    {
        private readonly IClickRecordService _ClickRecordService;

        public RankApiController(IClickRecordService clickRecordService)
        {
            _ClickRecordService = clickRecordService;
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
                if(id==0)
                {
                    var result = _ClickRecordService.ReadAllRank();
                    return Ok(result);

                }
                else
                {
                    var result = _ClickRecordService.ReadOtherTagRank(id);
                    return Ok(result);
                }
                //return new ObjectResult(result);
                
            }
            catch(Exception ex)
            {
                //return new ObjectResult($"錯誤訊息{ex}");
                return Ok($"錯誤訊息{ex}");
            }
        }
    }
}
