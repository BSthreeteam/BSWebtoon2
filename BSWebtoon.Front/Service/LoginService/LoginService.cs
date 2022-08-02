using BSWebtoon.Front.Models.DTO.UploadComicDTO;
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
            //var HotComicNameImageOutput = await _cloudinaryService.UploadAsync(input.HotComicNameImage);
            //if (!HotComicNameImageOutput.IsSuccess)
            //{

            //}
            var BgCoverOutput = await _cloudinaryService.UploadAsync(input.BgCover);
            //if (!BgCoverOutput.IsSuccess)
            //{

            //}

            //var HotBgCoverOutput = await _cloudinaryService.UploadAsync(input.HotBgCover);
            //if (!HotBgCoverOutput.IsSuccess)
            //{

            //}
            var ComicFigureOutput = await _cloudinaryService.UploadAsync(input.ComicFigure);
            //if (!ComicFigureOutput.IsSuccess)
            //{

            //}

            //var ComicWeekFigureOutput = await _cloudinaryService.UploadAsync(input.ComicWeekFigure);
            //if (!ComicWeekFigureOutput.IsSuccess)
            //{

            //}



            Member user = _repository.GetAll<Member>().First(x => x.MemberId == input.MemberId);
            if (input.IsNewAuthorName)
            {
                //作者筆名 不可重複
                var IsAuthorNameExist = _repository.GetAll<Comic>().Any(x =>  x.Author == input.Author);
                result.Message = "已有重複名稱";
                return result;

                try
                {
                    //user = _repository.GetAll<Member>().First(x => x.AccountName == "poyou chen");
                    user.NickName = input.Author;

                    _context.Update(user);
                    _context.SaveChanges();
                    result.HasNickName = true;
                }
                catch
                {
                    result.HasNickName = false;
                    result.Message = "寫入作者名稱失敗";
                    return result;
                }
            }
            

            if(user.NickName != input.Author) {
                result.Message = "漫畫作者名 和 會員作者名不一致";
                return result;
            }

            #region 建議包交易 / try


            using (var tran = _repository.Context.Database.BeginTransaction())
            {
                try
                {
                    //存入資料庫
                    //要改
                    var ComicInfo = new Comic()
                    {
                        ComicChineseName = input.ComicChineseName,
                        ComicEnglishName = "ROG-STRIX",
                        ComicNameImage = "https://tw-a.kakaopagecdn.com/P/C/206/aclip/58b296b7-3ee4-4db4-8a63-393ce2160637.webm",
                        //HotComicNameImage = HotComicNameImageOutput.Url,
                        HotComicNameImage = "https://tw-a.kakaopagecdn.com/P/C/206/aclip/58b296b7-3ee4-4db4-8a63-393ce2160637.webm",
                        //BgCover = BgCoverOutput.Url,
                        BgCover = "https://tw-a.kakaopagecdn.com/P/C/206/aclip/58b296b7-3ee4-4db4-8a63-393ce2160637.webm",
                        //HotBgCover = HotBgCoverOutput.Url,
                        HotBgCover = "https://tw-a.kakaopagecdn.com/P/C/206/aclip/58b296b7-3ee4-4db4-8a63-393ce2160637.webm",
                        //ComicFigure = ComicFigureOutput.Url,
                        ComicFigure = "https://tw-a.kakaopagecdn.com/P/C/206/aclip/58b296b7-3ee4-4db4-8a63-393ce2160637.webm",
                        ComicWeekFigure = "https://tw-a.kakaopagecdn.com/P/C/206/aclip/58b296b7-3ee4-4db4-8a63-393ce2160637.webm",
                        BgColor = "#999",
                        PublishDate = input.PublishDate,
                        LastPublishDate = DateTime.UtcNow,
                        FinallyPublishDate = DateTime.UtcNow,
                        UpdateWeek = input.UpdateWeek,
                        Publisher = input.Publisher,
                        Painter = input.Painter,
                        Author = input.Author,
                        Introduction = input.Introduction,
                        BannerVideoWeb = "https://tw-a.kakaopagecdn.com/P/C/206/aclip/58b296b7-3ee4-4db4-8a63-393ce2160637.webm",
                        WeekVideoWrb = "https://tw-a.kakaopagecdn.com/P/C/206/aclip/58b296b7-3ee4-4db4-8a63-393ce2160637.webm",
                        ComicVideoWeb = "https://tw-a.kakaopagecdn.com/P/C/206/aclip/58b296b7-3ee4-4db4-8a63-393ce2160637.webm",
                        HotVideo = "https://tw-a.kakaopagecdn.com/P/C/206/aclip/58b296b7-3ee4-4db4-8a63-393ce2160637.webm",

                        //AuditType = (int)Enum.Parse(typeof(AuditType), "Unaudit"),
                        AuditType = (int)AuditType.Unaudit,
                        AuditEmployeeId = 2,
                        ComicStatus = 3,
                    };
                    //寫入資料
                    var e = _context.Comics.Add(ComicInfo);
                    _context.SaveChanges();



                    //查到資料庫那個主標的id
                    var tagId = _repository.GetAll<ComicTag>().First(x => x.TagName == input.ComicTagList).TagId;
                    //寫入資料
                    _context.ComicTagLists.Add(
                        new ComicTagList()
                        {
                            TagId = tagId,
                            ComicId = e.Entity.ComicId,
                        }
                    );
                    _context.SaveChanges();


                    //沒選資料就不寫入資料庫
                    if (input.Comic_subtitle != "1")
                    {
                        //取到資料庫次要標題(1)
                        var ComicTagList = new ComicTagList()
                        {

                            TagId = _repository.GetAll<ComicTag>().First(x => x.TagName == input.Comic_subtitle).TagId,

                            ComicId = e.Entity.ComicId,
                        };
                        //寫入資料
                        _context.ComicTagLists.Add(ComicTagList);
                        //存入資料庫
                        _context.SaveChanges();
                    }

                    //沒選資料就不寫入資料庫
                    if (input.Comic_subtitle_tow != "1")
                    {
                        //取到資料庫次要標題(2)
                        var ComicTagList = new ComicTagList()
                        {

                            TagId = _repository.GetAll<ComicTag>().First(x => x.TagName == input.Comic_subtitle_tow).TagId,

                            ComicId = e.Entity.ComicId,
                        };
                        //寫入資料
                        _context.ComicTagLists.Add(ComicTagList);
                        //存入資料庫
                        _context.SaveChanges();
                    }

                    //沒選資料就不寫入資料庫
                    if (input.Comic_subtitle_three != "1")
                    {
                        //取到資料庫次要標題(3)
                        var ComicTagList = new ComicTagList()
                        {

                            TagId = _repository.GetAll<ComicTag>().First(x => x.TagName == input.Comic_subtitle_three).TagId,

                            ComicId = e.Entity.ComicId,
                        };
                        //寫入資料
                        _context.ComicTagLists.Add(ComicTagList);
                        //存入資料庫
                        _context.SaveChanges();
                    }


                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    //throw ex;

                    //導覽...或回物件到action...
                    result.Message = "寫入漫畫 或 查主標失敗";
                    return result;
                }
            }

            #endregion

            result.IsSuccess = true;
            return result;
        }


        //取得會員表裡面的 NickName 也就是作者名稱方法
        public string GetNickName(int userid)
        {
            var result = new UploadComicOutputDTO()
            {
                IsSuccess = false,

            };
            string user = "";
            //try
            //{
                user = _repository.GetAll<Member>().First(x => x.MemberId == userid).NickName;
            //    result.HasNickName = true;
            //    result.IsSuccess = true;
            //}
            //catch
            //{
            //    result.IsSuccess = true;
            //    result.HasNickName = false;
            //    return result;

            //}

            //result.Author = user;

            //return result;

            return user;
        }

        //讀取到目前作者所有上傳的漫畫與話次
        public GetComicInfoOutputDTO GetComicInfoToUploadEp(GetComicInfoInputDTO input)
        {

            var result = new GetComicInfoOutputDTO()
            {
                //把預設為 IsSuccess 的狀態設定成 false 。
                IsSuccess = false,
                //取得 GetComicInfoOutputDTO 裡面的 ComicWithEpCount 物件，在存入 GetComicInfoOutputDTO 宣告的欄位 MyComics_WithEpCount 做存放。
                MyComics_WithEpCount = new List<GetComicInfoOutputDTO.ComicWithEpCount>(),
            };

            //檢查
            //if(){ }


            //主邏輯

            //Id => 作者名
            string author = _repository.GetAll<Member>().First(x => x.MemberId == input.MemberId).NickName;

            //作者名 => 所有此作者漫畫
            var myComics = _repository.GetAll<Comic>().Where(c => c.Author == author && c.AuditType == 1) //審過
                .Select(c => new GetComicInfoOutputDTO.ComicWithEpCount
                {
                    ComicId = c.ComicId,
                    ComicChineseName = c.ComicChineseName,
                })//.ToList() 
                ;


            //每部漫畫 => ComicWithEpCount
            foreach (var c in myComics)
            {
                //查此漫畫的  最末話
                //先找到屬於這個會員的所有話次
                var a = _repository.GetAll<Episode>().Where(x => x.ComicId == c.ComicId);

                //找到查此漫畫的所有話次的內容總數
                c.EpCount = a.Count();
                if (c.EpCount > 0)
                {
                    //用AuditTime審計時間來查，此部漫畫的話次內容目前上傳到最末話的狀態，先把AuditTime審計時間做由大到小排序，再找出唯一的第一個EpTitle
                    //?，就是null條件運算子
                    c.EpName = a.OrderByDescending(x => x.AuditTime).FirstOrDefault()?.EpTitle;
                }

                //把結果，先存入 MyComics_WithEpCount 的DTO，再存入 GetComicInfoOutputDTO
                result.MyComics_WithEpCount.Add(c);
            };

            //如果上面的商業邏輯程式都運算成功的話，把預設為 IsSuccess 的 false 改為 true 。 
            result.IsSuccess = true;

            //最後再把所有的結果做回傳
            return result;
        }


        //上傳EP與EP內容方法
        //實作方法
        //使用非同步方式，宣告 UploadWorkOutputDTO 型別 加上 自訂名稱的方法名稱(收 UploadWorkInputDTO 型別 加上 自訂名稱的參數)
        public async Task<UploadEpOutputDTO> UploadEp(UploadEpInputDTO input)
        {


            var result = new UploadEpOutputDTO()
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
                ComicId = input.ComicId,//_repository.GetAll<Comic>().SingleOrDefault(x => x.ComicChineseName == input.ComicChineseName && x.Author == input.Author).ComicId,
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

        
    }
}
