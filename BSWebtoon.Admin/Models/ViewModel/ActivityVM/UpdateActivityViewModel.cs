using Microsoft.AspNetCore.Http;
using System;

namespace BSWebtoon.Admin.Models.ViewModel.ActivityVM
{
    public class UpdateActivityViewModel
    {
        //活動名稱
        public string ActivityName { get; set; }

        //活動圖片
        public string ActivityImage { get; set; }

        //活動開始時間
        public DateTime ActivityStartTime { get; set; }
        //活動結束時間
        public DateTime ActivityEndTime { get; set; }
        //活動文案
        public string ActivityContent { get; set; }
        //活動背景色號
        public string ActivityBgColor { get; set; }
        //員工名稱
        public int ActivityEmployeeName { get; set; }
    }
}
