using BSWebtoon.Admin.IDapperRepository;
using BSWebtoon.Admin.Models.DTO.AdminUploadComicDTO;
using BSWebtoon.Admin.Service.AdminComicCloudinaryService;
using BSWebtoon.Model;
using BSWebtoon.Model.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BSWebtoon.Admin.Service.AdminUploadComicService
{
    public class AdminUploadComicService : IAdminUploadComicService
    {

        private readonly IAdminComicCloudinaryService _adminComicCloudinaryService;
        private readonly IDapperAdminUploadComicRepository _adminUploadComicRepository;
        private readonly IDapperAdminComicTagListRepository _adminComicTagListRepository;
        public AdminUploadComicService( IAdminComicCloudinaryService adminComicCloudinaryService, IDapperAdminUploadComicRepository adminUploadComicRepository, IDapperAdminComicTagListRepository adminComicTagListRepository)
        {
            _adminComicCloudinaryService = adminComicCloudinaryService;
            _adminUploadComicRepository = adminUploadComicRepository;
            _adminComicTagListRepository = adminComicTagListRepository;
        }



        public async Task<AdminUploadComicDTO> UploadComicViewUpdateData(AdminUploadComicDTO input)
        {
            var result = new AdminUploadComicDTO()
            {
                IsSuccess = false,
            };

            ////用非同步方式呼叫 cloudinaryService 的 UploadAsync()方法，把使用者上傳的圖片傳入，會得到轉換過的網址，在存入變數

            var BgCoverOutput = await _adminComicCloudinaryService.UploadAsync(input.BgCover);
            var ComicWeekFigureOutput = await _adminComicCloudinaryService.UploadAsync(input.ComicWeekFigure);
            var ComicFigureOutput = await _adminComicCloudinaryService.UploadAsync(input.ComicFigure);
            var ComicNameImageOutput = await _adminComicCloudinaryService.UploadAsync(input.ComicNameImage);


            //C
            Comic comicEntity = new Comic
            {
                ComicChineseName=input.ComicChineseName,
                ComicEnglishName=input.ComicEnglishName,
                ComicNameImage = ComicNameImageOutput.Url,
                BgCover = BgCoverOutput.Url,
                ComicFigure = ComicFigureOutput.Url,
                ComicWeekFigure = ComicWeekFigureOutput.Url,
                BgColor = input.BgColor,
                PublishDate= input.PublishDate,
                UpdateWeek= input.UpdateWeek,
                Painter= input.Painter,
                Author= input.Author,
                Introduction= input.Introduction,
                AuditEmployeeId= input.AuditEmployeeId,
                ComicStatus= (int)ComicState.newWork,
                Publisher = "BSWebtoon",
                HotBgCover = BgCoverOutput.Url,
                LastPublishDate = input.PublishDate,
                HotComicNameImage = ComicNameImageOutput.Url,
                //AuditType = 1
            };
             _adminUploadComicRepository.Create(comicEntity);

            var comicIdSourse = _adminUploadComicRepository.SelectAll().Select(c=>c.ComicId);
            var tagListSourse = _adminComicTagListRepository.SelectAll().Select(c => c.ComicId);

            foreach(var item in tagListSourse)
            {
                if (!comicIdSourse.Contains(item))
                {
                    ComicTagList mainTagEntity = new ComicTagList
                    {
                        TagId = input.MainTag,
                        ComicId = item
                    };

                    _adminComicTagListRepository.Create(mainTagEntity);

                    if (input.Comic_subtitle != 0)
                    {
                        ComicTagList subtitleEntity = new ComicTagList
                        {
                            TagId = input.Comic_subtitle,
                            ComicId = item
                        };

                        _adminComicTagListRepository.Create(subtitleEntity);


                    }

                    if (input.Comic_subtitle_two != 0)
                    {
                        ComicTagList subtitleEntity = new ComicTagList
                        {
                            TagId = input.Comic_subtitle_two,
                            ComicId = item
                        };

                        _adminComicTagListRepository.Create(subtitleEntity);


                    }

                    if (input.Comic_subtitle_three != 0)
                    {
                        ComicTagList subtitleEntity = new ComicTagList
                        {
                            TagId = input.Comic_subtitle_three,
                            ComicId = item
                        };

                        _adminComicTagListRepository.Create(subtitleEntity);


                    }



                }
            }
           




            result.IsSuccess = true;
            return result;
        }


    }
}
