using BSWebtoon.Admin.Models.DTO.AdminUploadComicDTO;
using BSWebtoon.Admin.Service.AdminComicCloudinaryService;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BSWebtoon.Admin.Service.AdminUploadComicService
{
    public class AdminUploadComicService : IAdminUploadComicService
    {

        private readonly IAdminComicCloudinaryService _adminComicCloudinaryService;
        public AdminUploadComicService( IAdminComicCloudinaryService adminComicCloudinaryService)
        {
            _adminComicCloudinaryService = adminComicCloudinaryService;
        }



        //    public async Task<AdminUploadComicDTO> UploadComicViewUpdateData(AdminUploadComicDTO input)
        //    {
        //        var result = new AdminUploadComicDTO()
        //        {
        //            IsSuccess = false,
        //        };

        //        ////用非同步方式呼叫 cloudinaryService 的 UploadAsync()方法，把使用者上傳的圖片傳入，會得到轉換過的網址，在存入變數

        //        var BgCoverOutput = await _adminComicCloudinaryService.UploadAsync(input.BgCover);
        //        var ComicWeekFigureOutput = await _adminComicCloudinaryService.UploadAsync(input.ComicWeekFigure);



        //        var ComicFigureOutput = await _adminComicCloudinaryService.UploadAsync(input.ComicFigure);
        //        var ComicNameImageOutput = await _adminComicCloudinaryService.UploadAsync(input.ComicNameImage);





        //        #region 建議包交易 / try


        //        using (var tran = _repository.Context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                //存入資料庫
        //                //要改
        //                var ComicInfo = new Comic()
        //                {
        //                };
        //                //寫入資料
        //                var e = _repository.Comics.Add(ComicInfo);
        //                _repository.SaveChanges();



        //                //查到資料庫那個主標的id
        //                var tagId = _repository.GetAll<ComicTag>().First(x => x.TagName == input.ComicTagList).TagId;
        //                //寫入資料
        //                _context.ComicTagLists.Add(
        //                    new ComicTagList()
        //                    {
        //                        TagId = tagId,
        //                        ComicId = e.Entity.ComicId,
        //                    }
        //                );
        //                _context.SaveChanges();


        //                //沒選資料就不寫入資料庫
        //                if (input.Comic_subtitle != "1")
        //                {
        //                    //取到資料庫次要標題(1)
        //                    var ComicTagList = new ComicTagList()
        //                    {

        //                        TagId = _repository.GetAll<ComicTag>().First(x => x.TagName == input.Comic_subtitle).TagId,

        //                        ComicId = e.Entity.ComicId,
        //                    };
        //                    //寫入資料
        //                    _context.ComicTagLists.Add(ComicTagList);
        //                    //存入資料庫
        //                    _context.SaveChanges();
        //                }

        //                //沒選資料就不寫入資料庫
        //                if (input.Comic_subtitle_tow != "1")
        //                {
        //                    //取到資料庫次要標題(2)
        //                    var ComicTagList = new ComicTagList()
        //                    {

        //                        TagId = _repository.GetAll<ComicTag>().First(x => x.TagName == input.Comic_subtitle_tow).TagId,

        //                        ComicId = e.Entity.ComicId,
        //                    };
        //                    //寫入資料
        //                    _context.ComicTagLists.Add(ComicTagList);
        //                    //存入資料庫
        //                    _context.SaveChanges();
        //                }

        //                //沒選資料就不寫入資料庫
        //                if (input.Comic_subtitle_three != "1")
        //                {
        //                    //取到資料庫次要標題(3)
        //                    var ComicTagList = new ComicTagList()
        //                    {

        //                        TagId = _repository.GetAll<ComicTag>().First(x => x.TagName == input.Comic_subtitle_three).TagId,

        //                        ComicId = e.Entity.ComicId,
        //                    };
        //                    //寫入資料
        //                    _context.ComicTagLists.Add(ComicTagList);
        //                    //存入資料庫
        //                    _context.SaveChanges();
        //                }


        //                tran.Commit();
        //            }
        //            catch (Exception ex)
        //            {
        //                tran.Rollback();
        //                //throw ex;

        //                //導覽...或回物件到action...
        //                result.Message = "寫入漫畫 或 查主標失敗";
        //                return result;
        //            }
        //        }

        //        #endregion

        //        result.IsSuccess = true;
        //        return result;
        //    }


    }
}
