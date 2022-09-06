using BSWebtoon.Admin.IDapperRepository;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BSWebtoon.Admin.Controllers.WebApi
{
    [Route("/api/[controller]/[action]")]
    [ApiController]
    public class AuditComicApiController : Controller
    {
        protected readonly IDapperAuditComicRepository _dapperAuditComicRepository;
        public AuditComicApiController(IDapperAuditComicRepository dapperAuditComicRepository)
        {
            _dapperAuditComicRepository = dapperAuditComicRepository;
        }

        [HttpGet]
        public IActionResult AuditComic()
        {
            try
            {
                var result = _dapperAuditComicRepository.SelectAll();
                return Ok(result);
            }
            catch(Exception ex)
            {
                return Ok($"訊息錯誤{ex}");
            }
        }
    }
}
