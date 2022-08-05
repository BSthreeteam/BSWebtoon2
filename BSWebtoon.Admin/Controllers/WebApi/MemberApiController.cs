using BSWebtoon.Admin.IDapperRepository;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BSWebtoon.Admin.Controllers.WebApi
{
    [Route("/api/[controller]/[action]")]
    [ApiController]
    public class MemberApiController : Controller
    {
        protected readonly IDapperMemberRepository _dapperMemberRepository;
        public MemberApiController (IDapperMemberRepository dapperMemberRepository)
        {
            _dapperMemberRepository = dapperMemberRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
            var result = _dapperMemberRepository.SelectAll();
            return Ok(result);
            }
            catch(Exception ex)
            {
                return Ok($"訊息錯誤{ex}");
            }
        }
    }
}
