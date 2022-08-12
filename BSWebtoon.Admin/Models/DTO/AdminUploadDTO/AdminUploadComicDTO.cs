using Microsoft.AspNetCore.Http;
using System;

namespace BSWebtoon.Admin.Models.DTO.AdminUploadDTO
{
    public class AdminUploadComicDTO : BaseOutputDTO
    {

        ////防呆
        //[Required(ErrorMessage = "必須輸入")]
        ////限制字輸入長度
        //[StringLength(25, MinimumLength = 1, ErrorMessage = "漫畫中文名稱長度需介於 1-25字")]
        ////漫畫中文名稱
        ///
        ////防呆
        //[Required(ErrorMessage = "必須輸入")]
        ////星期列表人物圖
        public IFormFile ComicWeekFigure { get; set; }

        //防呆
        //[Required(ErrorMessage = "必須輸入")]
        //漫畫背景圖
        public IFormFile BgCover { get; set; }
        public IFormFile ComicFigure { get; set; }
        public IFormFile ComicNameImage { get; set; }
        public string ComicChineseName { get; set; }
        public string ComicEnglishName { get; set; }


        ////防呆
        //[Required(ErrorMessage = "必須輸入")]
        ////限制字輸入長度
        //[StringLength(25, MinimumLength = 1, ErrorMessage = "作者長度需介於 1-25字")]
        //作者
        public string Author { get; set; }

        ////防呆
        //[Required(ErrorMessage = "必須輸入")]
        ////限制字輸入長度
        //[StringLength(25, MinimumLength = 1, ErrorMessage = "繪者長度需介於 1-25字")]
        ////繪者
        public string Painter { get; set; }

        public int UpdateWeek { get; set; }

        ////防呆
        //[Required(ErrorMessage = "必須輸入")]
        ////發行日期
        public DateTime? PublishDate { get; set; }

        public string BgColor { get; set; }

        ////防呆
        //[Required(ErrorMessage = "必須輸入")]
        ////限制字輸入長度
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "故事大綱長度需介於 1-500字")]
        //故事大綱
        public string Introduction { get; set; }

        ////防呆
        //[Required(ErrorMessage = "必須輸入")]
        //[StringLength(99, MinimumLength = 2)]
        //漫畫類型
        public string MainTag { get; set; }

        //防呆
        //[Required(ErrorMessage = "必須輸入")]
        ////限制字輸入長度
        //[StringLength(25, MinimumLength = 1, ErrorMessage = "出版商長度需介於 1-25字")]
        //出版商
        public string Publisher { get; set; }

        ////防呆
        //[Required(ErrorMessage = "必須輸入")]
        //次要漫畫類型(1)
        public string? Comic_subtitle { get; set; }







        ////防呆
        //[Required(ErrorMessage = "必須輸入")]
        //次要漫畫類型(2)
        public string Comic_subtitle_two { get; set; }

        //防呆
        //[Required(ErrorMessage = "必須輸入")]
        //次要漫畫類型(3)
        public string Comic_subtitle_three { get; set; }




        //防呆
        //[Required(ErrorMessage = "必須輸入")]
        //[Range(1, 7)]
        //更新星期


        public int? AuditEmployeeId { get; set; }

    }
}
