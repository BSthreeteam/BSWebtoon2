using BSWebtoon.Admin.IDapperRepository;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BSWebtoon.Admin.Controllers.WebApi
{
    [Route("/api/[controller]/[action]")]
    [ApiController]
    public class DashboardApiController : Controller
    {
        protected readonly IDapperDashActivityRepository _dapperDashActivityRepository;
        protected readonly IDapperDashMemberRepository _dapperDashMemberRepository;
        protected readonly IDapperDashRankRepository _dapperDashRankRepository;
        protected readonly IDapperDashComicRepository _dapperDashComicRepository;
        [HttpGet]
        public IActionResult GetActivityChart()
        {
            try
            {
                var result = _dapperDashActivityRepository.SelectAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok($"訊息錯誤{ex}");
            }
        }
        [HttpGet]
        public IActionResult GetMemberChart()
        {
            try
            {
                var result = _dapperDashMemberRepository.SelectAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok($"訊息錯誤{ex}");
            }
        }
        [HttpGet]
        public IActionResult GetRankChart()
        {
            try
            {
                var result = _dapperDashRankRepository.SelectAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok($"訊息錯誤{ex}");
            }
        }
        [HttpGet]
        public IActionResult GetComicChart()
        {
            try
            {
                var result = _dapperDashComicRepository.SelectAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok($"訊息錯誤{ex}");
            }
        }
    }
}
