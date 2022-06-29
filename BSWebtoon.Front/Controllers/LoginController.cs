using BSWebtoon.Front.Service.MemberService;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class LoginController : Controller
    {
        private readonly IMemberService _memberService;
        private readonly BSRepository _repository;

        public LoginController(IMemberService memberService, BSRepository repository)
        {
            _memberService = memberService;
            _repository = repository;
        }
        public IActionResult AddMemberView()//Login/AddMemberView
        {
            _memberService.MemberCreate();
            return View();
        }
        public IActionResult AddLoginTypeView() //Login/AddLoginTypeView
        {
            _memberService.LoginTypeCreate();
            return View();
        }
        
    }
}
