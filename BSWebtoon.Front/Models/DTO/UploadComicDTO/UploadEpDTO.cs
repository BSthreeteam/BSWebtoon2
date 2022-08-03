using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BSWebtoon.Front.Models.DTO.UploadComicDTO
{

    public class UploadEpInputDTO
    {
        public int ComicId { get; set; }


        //防呆
        [Required(ErrorMessage = "必須輸入")]
        public string EpTitle { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        public IFormFile EpCover { get; set; }

        //防呆
        [Required(ErrorMessage = "必須輸入")]
        public List<IFormFile> EP_Context_file { get; set; }


        //收前一頁漫畫上傳的使用者輸入的漫畫名稱參數
        public string ComicChineseName { get; set; }

        //收前一頁漫畫上傳的使用者輸入的作者名稱參數
        public string Author { get; set; }

    }

    public class UploadEpOutputDTO : BaseOutputDTO
    {
        //防呆
        [Required(ErrorMessage = "必須輸入")]
        public string EpTitle { get; set; }

        public string EpCover { get; set; }

        public string EP_Context_file { get; set; }

        //收前一頁漫畫上傳的使用者輸入的漫畫名稱參數
        public string ComicChineseName { get; set; }

        //收前一頁漫畫上傳的使用者輸入的作者名稱參數
        public string Author { get; set; }
    }
}
