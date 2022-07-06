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
        public IActionResult AddMemberView()//Login/AddMemberView(我沒有建View，執行了找不到View沒關係，資料還是會進資料庫!!)
        {
            _memberService.MemberCreate();
            return View();
        }



        //public IActionResult AddLoginTypeView() //Login/AddLoginTypeView
        //{
        //    //_memberService.LoginTypeCreate();
        //    _memberService.MemberUpdateData();
        //    return View();
        //}

    }
}
