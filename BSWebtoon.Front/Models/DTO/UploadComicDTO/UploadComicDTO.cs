using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BSWebtoon.Front.Models.DTO.UploadComicDTO
{
    public class UploadComicInputDTO
    {
        public string UserId { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //限制字輸入長度
        [StringLength(25, MinimumLength = 1, ErrorMessage = "漫畫中文名稱長度需介於 1-25字")]
        //漫畫中文名稱
        public string ComicChineseName { get; set; }

        ////防呆
        //[Required(ErrorMessage = "必須輸入")]
        ////漫畫名稱圖
        //public IFormFile ComicNameImage { get; set; }

        //////防呆
        ////[Required(ErrorMessage = "必須輸入")]
        //////強檔劇獻名稱圖
        ////public IFormFile HotComicNameImage { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //漫畫背景圖
        public IFormFile BgCover { get; set; }

        ////防呆
        //[Required(ErrorMessage = "必須輸入")]
        ////強檔劇獻背景圖
        //public IFormFile HotBgCover { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //人物圖
        public IFormFile ComicFigure { get; set; }

        ////防呆
        //[Required(ErrorMessage = "必須輸入")]
        ////星期列表人物圖
        //public IFormFile ComicWeekFigure { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //限制字輸入長度
        [StringLength(25, MinimumLength = 1, ErrorMessage = "出版商長度需介於 1-25字")]
        //出版商
        public string Publisher { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //限制字輸入長度
        [StringLength(25, MinimumLength = 1, ErrorMessage = "繪者長度需介於 1-25字")]
        //繪者
        public string Painter { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //限制字輸入長度
        [StringLength(25, MinimumLength = 1, ErrorMessage = "作者長度需介於 1-25字")]
        //作者
        public string Author { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //限制字輸入長度
        [StringLength(500, MinimumLength = 1, ErrorMessage = "故事大綱長度需介於 1-500字")]
        //故事大綱
        public string Introduction { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //漫畫類型
        public string ComicTagList { get; set; }


        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //次要漫畫類型(1)
        public string Comic_subtitle { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //次要漫畫類型(2)
        public string Comic_subtitle_tow { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //次要漫畫類型(3)
        public string Comic_subtitle_three { get; set; }


        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //發行日期
        public DateTime PublishDate { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //更新星期
        public int UpdateWeek { get; set; }



    }


    public class UploadComicOutputDTO : BaseOutputDTO
    {

        public bool HasNickName { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //漫畫中文名稱
        public string ComicChineseName { get; set; }

        ////防呆
        //[Required(ErrorMessage = "必須輸入")]
        ////漫畫名稱圖
        //public IFormFile ComicNameImage { get; set; }

        //////防呆
        ////[Required(ErrorMessage = "必須輸入")]
        //////強檔劇獻名稱圖
        ////public IFormFile HotComicNameImage { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //漫畫背景圖
        public IFormFile BgCover { get; set; }

        ////防呆
        //[Required(ErrorMessage = "必須輸入")]
        ////強檔劇獻背景圖
        //public IFormFile HotBgCover { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //人物圖
        public IFormFile ComicFigure { get; set; }

        ////防呆
        //[Required(ErrorMessage = "必須輸入")]
        ////星期列表人物圖
        //public IFormFile ComicWeekFigure { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //出版商
        public string Publisher { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //繪者
        public string Painter { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //作者
        public string Author { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //故事大綱
        public string Introduction { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //漫畫類型
        public string ComicTagList { get; set; }


        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //次要漫畫類型(1)
        public string Comic_subtitle { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //次要漫畫類型(2)
        public string Comic_subtitle_tow { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //次要漫畫類型(3)
        public string Comic_subtitle_three { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //發行日期
        public DateTime PublishDate { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        //更新星期
        public int UpdateWeek { get; set; }



    }
}
