using BSWebtoon.Model.Models;
using Microsoft.AspNetCore.Http;
using System;

namespace BSWebtoon.Admin.Models.DTO.Activitys
{
    public class UpdateActivityInputDTO : Activity
    {
        //活動編號
        public int ActivityId { get; set; }

        //活動名稱
        public string ActivityName { get; set; }

        //活動圖片
        public IFormFile ActivityImage { get; set; }

        //活動開始時間
        public DateTime ActivityStartTime { get; set; }
        //活動結束時間
        public DateTime ActivityEndTime { get; set; }
        //活動文案
        public string ActivityContent { get; set; }
        //活動背景色號
        public string ActivityBgColor { get; set; }
        
    }


    public class UpdateActivityOutputDTO : BaseOutputDTO
    {
        //活動編號
        public string ActivityId { get; set; }

        //活動名稱
        public string ActivityName { get; set; }

        //活動圖片
        public IFormFile ActivityImage { get; set; }

        //活動開始時間
        public DateTime ActivityStartTime { get; set; }
        //活動結束時間
        public DateTime ActivityEndTime { get; set; }
        //活動文案
        public string ActivityContent { get; set; }
        //活動背景色號
        public string ActivityBgColor { get; set; }
        
    }

}
