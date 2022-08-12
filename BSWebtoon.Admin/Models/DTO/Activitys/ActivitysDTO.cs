using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System;

namespace BSWebtoon.Admin.Models.DTO.Activitys
{
    public class ActivitysInputDTO
    {        

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

        public int ActivityEmployeeName { get; set; }

        //活動背景色號
        public string ActivityBgColor { get; set; }


    }

    public class ActivitysOutputDTO : BaseOutputDTO
    {

        //活動名稱
        public string ActivityName { get; set; }
        //活動開始時間
        public DateTime ActivityStartTime { get; set; }
        //活動結束時間
        public DateTime ActivityEndTime { get; set; }
        //活動圖片
        public IFormFile ActivityImage { get; set; }
        //活動文案
        public string ActivityContent { get; set; }

        public int ActivityEmployeeName { get; set; }

        //活動背景色號
        public string ActivityBgColor { get; set; }
    }
}
