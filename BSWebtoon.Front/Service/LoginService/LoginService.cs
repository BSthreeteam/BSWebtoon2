using BSWebtoon.Front.Models.DTO.UploadComicDTO;
using BSWebtoon.Front.Models.DTO.UploadWorkView;
using BSWebtoon.Front.Service.CloudinaryService;
using BSWebtoon.Model.Models;
using BSWebtoon.Model;
using BSWebtoon.Model.Repository;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BSWebtoon.Front.Service.LoginService
{

    public class LoginService : ILoginService
    {
        //初始化建構式: DI注入
        private readonly BSRepository _repository;

        //private readonly IHttpContextAccessor _httpContextAccessor;
        //private readonly IConfiguration _config;
        //private readonly Cloudinary _cloudinary;

        private readonly ICloudinaryService _cloudinaryService;

        private readonly BSWebtoonDbContext _context;


        public LoginService(BSRepository repository, /*IConfiguration config,*/ BSWebtoonDbContext context, ICloudinaryService cloudinaryService)
        {
            _repository = repository;

            //_config = config;

            _context = context;

            _cloudinaryService = cloudinaryService;

            ////登入帳號
            //string cloudname = _config["Cloudinary:cloudname"];
            //string apikey = _config["Cloudinary:apikey"];
            //string apisecret = _config["Cloudinary:apisecret"];

            //Account account = new Account(cloudname, apikey, apisecret);

            //_cloudinary = new Cloudinary(account);
            //_cloudinary.Api.Secure = true;

        }






        //實作方法
        //使用非同步方式，宣告 UploadWorkOutputDTO 型別 加上 自訂名稱的方法名稱(收 UploadWorkInputDTO 型別 加上 自訂名稱的參數)
        public async Task<UploadWorkOutputDTO> UploadWorkViewUpdateData(UploadWorkInputDTO input)
        {


            var result = new UploadWorkOutputDTO()
            {
                IsSuccess = false,
                Message = "",
            };



            //要改UploadAsync()
            //用非同步方式呼叫 cloudinaryService 的 UploadAsync()方法，把使用者上傳的圖片傳入，會得到轉換過的網址，在存入變數
            var epCoverOutput = await _cloudinaryService.UploadAsync(input.EpCover);

            if (!epCoverOutput.IsSuccess)
            {

            }






            //存入資料庫
            var episodeInfo = new Episode()
            {
                ComicId = input.CommicId,//_repository.GetAll<Comic>().SingleOrDefault(x => x.ComicChineseName == input.ComicChineseName && x.Author == input.Author).ComicId,
                EpTitle = input.EpTitle,
                //取到回傳的網址
                EpCover = epCoverOutput.Url,

                UploadTime = DateTime.UtcNow.AddHours(8),
                UpdateTime = DateTime.UtcNow.AddHours(8),

                AuditType = 2,
                AuditFailReason = "未通過",
                IsCountdownCoupon = true,
                IsFree = false,

            };
            //img = episodeInfo.EpCover;
            //寫入資料
            var ep = _context.Episodes.Add(episodeInfo);

            //存入資料庫
            _context.SaveChanges();


            //讓 EpContent 的表裡面的 Page 欄位的值，依照上傳的數量照順序給值，ex:上傳4張， 第一張圖 Page = 1、第二張圖 Page = 2、第三張圖 Page = 3、第四張圖 Page = 4。
            //因此讓 EpContent 的表裡面的 Page 欄位的值，起始值為 1 。
            int i = 1;
            //把使用者所上傳的多個檔案，依序迭帶出來。
            foreach (var epContentConOutput in input.EP_Context_file)
            {
                //用非同步方式呼叫 cloudinaryService 的 UploadAsync()方法，把使用者上傳的圖片傳入，會得到轉換過的網址，在存入變數
                var epContentConOutput_result = await _cloudinaryService.UploadAsync(epContentConOutput);


                //存入資料庫
                var epContentInfo = new EpContent()
                {
                    EpId = ep.Entity.EpId,
                    ImagePath = epContentConOutput_result.Url,

                    //依照上傳的數量照順序給值，ex:上傳4張， 第一張圖 Page = 1、第二張圖 Page = 2、第三張圖 Page = 3、第四張圖 Page = 4。
                    Page = i++


                };
                //img = episodeInfo.EpCover;
                //寫入資料
                _context.EpContents.Add(epContentInfo);
                ;
                //存入資料庫
                _context.SaveChanges();

            }






            return result;

        }

        public UploadComicOutputDTO GetNickName(string userName)
        {
            var result = new UploadComicOutputDTO()
            {
                IsSuccess = false,

            };
            string user = "";
            try
            {
                user = _repository.GetAll<Member>().First(x => x.AccountName == userName).NickName;
                result.HasNickName = true;
                result.IsSuccess = true;
            }
            catch
            {
                result.IsSuccess = true;
                result.HasNickName = false;
                return result;

            }

            result.Author = user;
            return result;
        }

        //漫畫封面上傳
        public async Task<UploadComicOutputDTO> UploadComicViewUpdateData(UploadComicInputDTO input)
        {

            var result = new UploadComicOutputDTO()
            {
                IsSuccess = false,

            };

            ////用非同步方式呼叫 cloudinaryService 的 UploadAsync()方法，把使用者上傳的圖片傳入，會得到轉換過的網址，在存入變數
            //var ComicNameImageOutput = await _cloudinaryService.UploadAsync(input.ComicNameImage);
            ////防呆
            //if (!ComicNameImageOutput.IsSuccess)
            //{

            //}
            ////用非同步方式呼叫 cloudinaryService 的 UploadAsync()方法，把使用者上傳的圖片傳入，會得到轉換過的網址，在存入變數
            //var HotComicNameImageOutput = await _cloudinaryService.UploadAsync(input.HotComicNameImage);
            ////防呆
            //if (!HotComicNameImageOutput.IsSuccess)
            //{

            //}
            //用非同步方式呼叫 cloudinaryService 的 UploadAsync()方法，把使用者上傳的圖片傳入，會得到轉換過的網址，在存入變數
            var BgCoverOutput = await _cloudinaryService.UploadAsync(input.BgCover);
            //防呆
            if (!BgCoverOutput.IsSuccess)
            {

            }
            ////用非同步方式呼叫 cloudinaryService 的 UploadAsync()方法，把使用者上傳的圖片傳入，會得到轉換過的網址，在存入變數
            //var HotBgCoverOutput = await _cloudinaryService.UploadAsync(input.HotBgCover);
            ////防呆
            //if (!HotBgCoverOutput.IsSuccess)
            //{

            //}
            //用非同步方式呼叫 cloudinaryService 的 UploadAsync()方法，把使用者上傳的圖片傳入，會得到轉換過的網址，在存入變數
            var ComicFigureOutput = await _cloudinaryService.UploadAsync(input.ComicFigure);
            //防呆
            if (!ComicFigureOutput.IsSuccess)
            {

            }
            ////用非同步方式呼叫 cloudinaryService 的 UploadAsync()方法，把使用者上傳的圖片傳入，會得到轉換過的網址，在存入變數
            //var ComicWeekFigureOutput = await _cloudinaryService.UploadAsync(input.ComicWeekFigure);
            ////防呆
            //if (!ComicWeekFigureOutput.IsSuccess)
            //{

            //}






            //先執行錯誤
            //try
            //{

                //var Check_Author = _repository.GetAll<Comic>().First(x => x.ComicChineseName == input.ComicChineseName && x.Author == input.Author);
                //result.IsSuccess = false;
                ////result.Message = "已有重複名稱";

                //var Check_Author = _repository.GetAll<Comic>().First(x => x.Author);
                //var user = _repository.GetAll<Member>().First(x => x.Email == input.UserId).NickName;
                result.IsSuccess = false;



            //}
            //catch//沒錯誤執行下面
            //{
                //防呆
                if (input.ComicTagList == "1")
                {
                    result.IsSuccess = false;
                    return result;
                }
                //防呆
                if (input.UpdateWeek == 1)
                {
                    result.IsSuccess = false;
                    return result;
                }



                //存入資料庫
                //要改
                var ComicInfo = new Comic()
                {
                    ComicChineseName = input.ComicChineseName,
                    ComicEnglishName = "ROG-STRIX",
                    ComicNameImage = "https://tw-a.kakaopagecdn.com/P/C/206/aclip/58b296b7-3ee4-4db4-8a63-393ce2160637.webm",
                    //HotComicNameImage = HotComicNameImageOutput.Url,
                    HotComicNameImage = "https://tw-a.kakaopagecdn.com/P/C/206/aclip/58b296b7-3ee4-4db4-8a63-393ce2160637.webm",
                    BgCover = BgCoverOutput.Url,
                    //HotBgCover = HotBgCoverOutput.Url,
                    HotBgCover = "https://tw-a.kakaopagecdn.com/P/C/206/aclip/58b296b7-3ee4-4db4-8a63-393ce2160637.webm",
                    ComicFigure = BgCoverOutput.Url,
                    ComicWeekFigure = "https://tw-a.kakaopagecdn.com/P/C/206/aclip/58b296b7-3ee4-4db4-8a63-393ce2160637.webm",
                    BgColor = "#999",
                    PublishDate = input.PublishDate,
                    LastPublishDate = DateTime.Now,
                    FinallyPublishDate = DateTime.Now,
                    UpdateWeek = input.UpdateWeek,
                    Publisher = input.Publisher,
                    Painter = input.Painter,
                    Author = input.Author,
                    Introduction = input.Introduction,
                    BannerVideoWeb = "https://tw-a.kakaopagecdn.com/P/C/206/aclip/58b296b7-3ee4-4db4-8a63-393ce2160637.webm",
                    WeekVideoWrb = "https://tw-a.kakaopagecdn.com/P/C/206/aclip/58b296b7-3ee4-4db4-8a63-393ce2160637.webm",
                    ComicVideoWeb = "https://tw-a.kakaopagecdn.com/P/C/206/aclip/58b296b7-3ee4-4db4-8a63-393ce2160637.webm",
                    HotVideo = "https://tw-a.kakaopagecdn.com/P/C/206/aclip/58b296b7-3ee4-4db4-8a63-393ce2160637.webm",
                    AuditType = (int)Enum.Parse(typeof(AuditType), "未審核"),
                    AuditEmployeeId = 2,
                    ComicStatus = 3,
                };
                //寫入資料
                var e = _context.Comics.Add(ComicInfo);
                ;
                //存入資料庫
                _context.SaveChanges();



            //寫入會員表
            //var meberName = new Member()
            //{
            //    NickName = input.Author
            //};
            //寫入資料
            //_context.Members.Add(meberName);
            //;
            Member user;
            try
            {
                user = _repository.GetAll<Member>().First(x => x.AccountName == "poyou chen");
                user.NickName = input.Author;
                //存入資料庫
                _context.SaveChanges();
                result.HasNickName = true;
            }
            catch
            {
                result.HasNickName = false;

            }









            //取到資料庫主要標題
            var ComicTagListMain = new ComicTagList()
                {
                    //查道那個主標的id
                    TagId = _repository.GetAll<ComicTag>().First(x => x.TagName == input.ComicTagList).TagId,
                    ComicId = e.Entity.ComicId,//328
                };
                //寫入資料
                _context.ComicTagLists.Add(ComicTagListMain);
                //存入資料庫
                _context.SaveChanges();


                



            //防呆，沒選資料就不寫入資料庫
            if (input.Comic_subtitle != "1")
                {
                    //取到資料庫次要標題(1)
                    var ComicTagList = new ComicTagList()
                    {

                        TagId = _repository.GetAll<ComicTag>().First(x => x.TagName == input.Comic_subtitle).TagId,

                        ComicId = e.Entity.ComicId,//328
                    };
                    //寫入資料
                    _context.ComicTagLists.Add(ComicTagList);
                    //存入資料庫
                    _context.SaveChanges();
                }

                //防呆，沒選資料就不寫入資料庫
                if (input.Comic_subtitle_tow != "1")
                {
                    //取到資料庫次要標題(2)
                    var ComicTagList = new ComicTagList()
                    {

                        TagId = _repository.GetAll<ComicTag>().First(x => x.TagName == input.Comic_subtitle_tow).TagId,

                        ComicId = e.Entity.ComicId,//328
                    };
                    //寫入資料
                    _context.ComicTagLists.Add(ComicTagList);
                    //存入資料庫
                    _context.SaveChanges();
                }

                //防呆，沒選資料就不寫入資料庫
                if (input.Comic_subtitle_three != "1")
                {
                    //取到資料庫次要標題(3)
                    var ComicTagList = new ComicTagList()
                    {

                        TagId = _repository.GetAll<ComicTag>().First(x => x.TagName == input.Comic_subtitle_three).TagId,

                        ComicId = e.Entity.ComicId,//328
                    };
                    //寫入資料
                    _context.ComicTagLists.Add(ComicTagList);
                    //存入資料庫
                    _context.SaveChanges();
                }

                result.IsSuccess = true;

            //}






            return result;
        }


    }
}
