using BSWebtoon.Front.Models.DTO.UploadComicDTO;
using BSWebtoon.Front.Service.CloudinaryService;
using BSWebtoon.Front.Service.LoginService;
using BSWebtoon.Front.Service.MemberService;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using static BSWebtoon.Front.Models.DTO.Login.LoginAccountDTO;

namespace BSWebtoon.Front.Controllers
{
    public class LoginController : Controller
    {
        private readonly IMemberService _memberService;

        private readonly BSRepository _repository;
        private readonly ICloudinaryService _cloudinaryService;

        private readonly ILoginService _loginSerice;
        public LoginController(IMemberService memberService, BSRepository repository, ICloudinaryService cloudinaryService, ILoginService loginSerice)
        {
            _memberService = memberService;

            _repository = repository;
            _cloudinaryService = cloudinaryService;
            _loginSerice = loginSerice;
        }



        public IActionResult AddMemberView()//Login/AddMemberView(我沒有建View，執行了找不到View沒關係，資料還是會進資料庫!!)
        {
            //_memberService.MemberCreate();
            return View();
        }
        public IActionResult AddLoginTypeView() //Login/AddLoginTypeView
        {
            //_memberService.LoginTypeCreate();
            //_memberService.MemberUpdateData();


            return View();
        }
        [HttpGet("~/Login/LoginOption/{scheme}")]
        public IActionResult LoginOption([FromRoute] string scheme)
        {
            //第三方的驗證
            var properties = new AuthenticationProperties
            {
                //【驗證】完，要重新導向到的網址
                RedirectUri = Url.Action(nameof(HandleResponse)),
            };
            //用指定的scheme 發起挑戰(=要你去做驗證
            return Challenge(properties, scheme);
        }
        public async Task<IActionResult> HandleResponse() // 挑戰完的 重導到此
        {
            //將 request請求 驗證
            var result = await HttpContext.AuthenticateAsync();

            var claims =
            User.Claims.Select(claim => new
            {
                claim.Issuer,//發行者
                claim.OriginalIssuer,
                claim.Type,//提供宣告的語意內容，也就是它指出宣告的用途。
                claim.Value,//顧名思義 質
            });

            var NameIdentifiers = claims.First(x => x.Type == ClaimTypes.NameIdentifier);
            var AccountName = claims.First(x => x.Type == ClaimTypes.Name);
            var Email = claims.First(x => x.Type == ClaimTypes.Email);




            var iutputDTO = new Login3rdInputDTO
            {
                Provider = NameIdentifiers.Issuer.ToLower(),
                NameIdentifier = NameIdentifiers.Value,
                AccountName = AccountName.Value,//用戶名稱
                NickName = AccountName.Value,
                Email = Email.Value,

            };
            await _memberService.LoginAccount(iutputDTO);

            return LocalRedirect("/");
        }
        public IActionResult Logout()
        {
            _memberService.LogoutAccountAsync();
            return Redirect("/");
        }



        //上傳漫畫
        [HttpGet]
        public IActionResult UploadComicView(int userId) //Login/UploadComicView
        {

            //取得會員ID
            var memberId = int.Parse(User.Claims.First(x => x.Type == "MemberID").Value);

            //var user = User.Identity.Name;

            ////預畫面設值
            //var outputDTO = new UploadComicOutputDTO
            //{
            //    IsSuccess = 0,
            //    EpTitle = "abc",
            //    EpCover = "https://inews.gtimg.com/newsapp_bt/0/14062897162/1000",
            //};

            //取得會員表裡面的 NickName 也就是作者名稱
            var nickName = _loginSerice.GetNickName(memberId);

            //預設表單上輸入框的值
            var vm = new UploadComicInputDTO
            {
                Painter = "Anke",
                Publisher = "Anke",
                Introduction = "qwe\r\nqweqwe",
                ComicChineseName = "ROG漫畫王",

                Author = nickName,
                PublishDate = DateTime.UtcNow.AddDays(1),
            };

            return View(vm);
        }

        //上傳漫畫
        [HttpPost]             //Login/UploadComicView
        //以非同步方式接收，使用者從表單輸入的所有的值。
        public async Task<IActionResult> UploadComicView([FromForm] UploadComicInputDTO input )
        {
            //防呆
            if (!ModelState.IsValid || input.PublishDate < DateTime.UtcNow.AddHours(8))
            {
                return View(input);//體貼地將資料填回去
            }


            //取得會員ID
            var memberId = int.Parse(User.Claims.First(x => x.Type == "MemberID").Value);

            //var user = User.Identity.Name;

            //if (input.Comic_subtitle == input.Comic_subtitle || input.Comic_subtitle == "1")
            //{
            //使用者從表單輸入的所有的值，依序存入對應的DTO欄位值，存入一個變數。

            input.MemberId = memberId;
            //var inputDTO = new UploadComicInputDTO()
            //{
            //    MemberId = memberId,
            //    ComicChineseName = input.ComicChineseName,
            //    //ComicNameImage = ComicNameImage,
            //    //HotComicNameImage = HotComicNameImage,
            //    BgCover = input.BgCover,
            //    //HotBgCover = HotBgCover,
            //    ComicFigure = input.ComicFigure,
            //    //ComicWeekFigure = ComicWeekFigure,
            //    Publisher = input.Publisher,
            //    Painter = input.Painter,
            //    Author = input.Author,
            //    Introduction = input.Introduction,
            //    ComicTagList = input.ComicTagList,

            //    Comic_subtitle = input.Comic_subtitle,
            //    Comic_subtitle_tow = input.Comic_subtitle_tow,
            //    Comic_subtitle_three = input.Comic_subtitle_three,
            //    PublishDate = input.PublishDate,
            //    UpdateWeek = input.UpdateWeek,
            //};

            TempData["ComicChineseName"] = input.ComicChineseName;
            TempData["Author"] = input.Author;

            //呼叫 loginSerice 的 UploadWorkViewUpdateData() 方法 傳入DTO所存放使用者從表單輸入的所有的值，存入一個變數。
            var outputDTO = await _loginSerice.UploadComicViewUpdateData(input);
            //ViewData["IsSuccess"] = outputDTO.IsSuccess;
            //ViewData["ErrorMsg"] = outputDTO.Message;


            //成敗分支

            if (!outputDTO.IsSuccess)
            {
                //if(outputDTO.HasNickName)...???
                //ViewData["x"] = outputDTO.Message;
                return View(input);
            }


            //var UploadWork_VM = new UploadWorkViewModel()
            //{
            //    UploadWork_VM.EpTitle = outputDTO.EpTitle,
            //    UploadWork_VM.EpCover = outputDTO.EpCover
            //};

            //return View(outputDTO);

            //return Content("上傳成功，正在審核中");

            //return View("WorksPage");

            //到上傳話次與內容頁
            return RedirectToAction("UploadWorkView", "Login");

            ////回到作品頁
            //return RedirectToAction("WorksPage", "WorksPage");

        }

        //上傳話次與內容頁
        [HttpGet]
        public IActionResult UploadWorkView() //Login/UploadWorkView
        {
            var inputDto = new GetComicInfoInputDTO
            {
                MemberId = int.Parse(User.Claims.First(x => x.Type == "MemberID").Value), //21
            };

            var outputDto= _loginSerice.GetComicInfoToUploadEp(inputDto);

            if (!outputDto.IsSuccess) {}

            ////預畫面設值
            //var outputDTO = new UploadWorkOutputDTO
            //{
            //    IsSuccess = 0,
            //    EpTitle = "abc",
            //    EpCover = "https://inews.gtimg.com/newsapp_bt/0/14062897162/1000",
            //};

            //去DB查此人 審過的漫畫
            //如果資料庫裡面沒有上傳過任何一部漫畫就不能進入上傳EP頁面，因此直接跳轉回上傳漫畫的頁面。
            if (outputDto.MyComics_WithEpCount.Count == 0)
            {
                RedirectToAction("UploadComicView");
            }
            
            ViewData["MyComics_WithEpCount"] = outputDto.MyComics_WithEpCount;

            //給表單預填值用
            return View( new UploadEpInputDTO() ); //outputDto.MyComics_WithEpCount[0]
        }

        //上傳話次與內容頁
        [HttpPost]
        //以非同步方式接收，使用者從表單輸入的所有的值。
        //改建ViewMolde
        public async Task<IActionResult> UploadWorkView([Bind]UploadEpInputDTO input
            //,  IFormFile EpCover, string EpTitle, List<IFormFile> EP_Context_file
            ) //Login/UploadWorkView
        {
            //防呆
            if (!ModelState.IsValid)
            {
                return View(input);//體貼地將資料填回去
            }

            //_memberService.UploadWorkViewUpdateData(file , Title);
            var ComicChineseName = TempData["ComicChineseName"] as string;
            var Author = TempData["Author"] as string;

            

            //防呆
            if (ComicChineseName == "" || ComicChineseName == ComicChineseName && Author == "" || Author == Author)
            {
                //使用者從表單輸入的所有的值，依序存入對應的DTO欄位值，存入一個變數。
                //var inputDTO = new UploadWorkInputDTO()
                //{
                //    CommicId = input.CommicId,
                //    EpTitle = EpTitle,
                //    EpCover = EpCover,
                //    ComicChineseName = ComicChineseName,
                //    EP_Context_file = EP_Context_file,
                //    Author = Author,

                //};
                input.Author = Author;
                input.ComicChineseName = ComicChineseName;


                //呼叫 loginSerice 的 UploadEp () 方法 傳入DTO所存放使用者從表單輸入的所有的值，存入一個變數。
                var outputDTO = await _loginSerice.UploadEp(input);

                if (!outputDTO.IsSuccess)
                {
                    ViewData["IsSuccessMsg"] = outputDTO.Message;
                    //return View(outputDTO);
                }
                else
                {
                    ViewData["IsSuccessMsg"] = "成功上傳，正在審核中!";
                }
            }

           return RedirectToAction("UploadWorkView");
            ////回到作品頁
            //return RedirectToAction("WorksPage", "WorksPage");

            //回到成功頁
            //return RedirectToAction("UploadedSuccessfullyView", "Login");


        }







        //成功頁
        public IActionResult UploadedSuccessfullyView() //Login/UploadedSuccessfullyView
        {
            return View();
        }



    }
}




