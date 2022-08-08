using BSWebtoon.Admin.IDapperRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace BSWebtoon.Admin.Controllers
{
    public class MemberController : Controller
    {
        private readonly IDapperMemberRepository _memberRepository;
        public MemberController(IDapperMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }
        public IActionResult Index()
        {
            
            var qAll = _memberRepository.SelectAll();
            return View();
        }


    }
}
