using BSWebtoon.Front.Models.DTO.UploadComicDTO;
using BSWebtoon.Front.Service.CloudinaryService;
using BSWebtoon.Front.Service.UploadService;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BSWebtoon.Front.Controllers
{
    public class UpLoadController : Controller
    {
        private readonly BSRepository _repository;
        private readonly ICloudinaryService _cloudinaryService;

        private readonly IUploadService _UploadService;
        public UpLoadController( BSRepository repository, ICloudinaryService cloudinaryService, IUploadService UploadService)
        {

            _repository = repository;
            _cloudinaryService = cloudinaryService;
            _UploadService = UploadService;
        }


        //上傳漫畫
        [HttpGet]
        public IActionResult UploadComic(int userId) // Upload/UploadComic
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
            var nickName = _UploadService.GetNickName(memberId);

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
        [HttpPost]             //Login/UploadComic
        //以非同步方式接收，使用者從表單輸入的所有的值。
        public async Task<IActionResult> UploadComic([FromForm] UploadComicInputDTO input)
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
            var outputDTO = await _UploadService.UploadComicViewUpdateData(input);
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
            return RedirectToAction("UploadWork", "Upload");

            ////回到作品頁
            //return RedirectToAction("WorksPage", "WorksPage");

        }



        //上傳話次與內容頁
        [HttpGet]
        public IActionResult UploadWork() //Upload/UploadWork
        {
            var inputDto = new GetComicInfoInputDTO
            {
                MemberId = int.Parse(User.Claims.First(x => x.Type == "MemberID").Value), //21
            };

            var outputDto = _UploadService.GetComicInfoToUploadEp(inputDto);

            if (!outputDto.IsSuccess) { }

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
                RedirectToAction("UploadComic");
            }

            ViewData["MyComics_WithEpCount"] = outputDto.MyComics_WithEpCount;

            //給表單預填值用
            return View(new UploadEpInputDTO()); //outputDto.MyComics_WithEpCount[0]
        }

        //上傳話次與內容頁
        [HttpPost]
        //以非同步方式接收，使用者從表單輸入的所有的值。
        //改建ViewMolde
        public async Task<IActionResult> UploadWork([Bind] UploadEpInputDTO input
            //,  IFormFile EpCover, string EpTitle, List<IFormFile> EP_Context_file
            ) //Login/UploadWork
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
                var outputDTO = await _UploadService.UploadEp(input);

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

            return RedirectToAction("UploadWork");
            ////回到作品頁
            //return RedirectToAction("WorksPage", "WorksPage");

            //回到成功頁
            //return RedirectToAction("UploadedSuccessfullyView", "Login");


        }


    }
}
