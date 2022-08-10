using BSWebtoon.Admin.IDapperRepository;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BSWebtoon.Admin.Controllers.WebApi
{
    [Route("/api/[controller]/[action]")]
    [ApiController]
    public class EmployeeApiController : Controller
    {
        protected readonly IDapperEmployeeRepository _dapperEmployeeRepository;
        public EmployeeApiController(IDapperEmployeeRepository dapperEmployeeRepository)
        {
            _dapperEmployeeRepository = dapperEmployeeRepository;
        }

        [HttpGet]
        public IActionResult management()
        {
            try
            {
                var result = _dapperEmployeeRepository.SelectAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok($"訊息錯誤{ex}");
            }
        }

    }
}
