using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSWebtoon.Model.ViewModel
{
    public class ActivityViewModel
    {
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public DateTime ActivityStartTime { get; set; }
        public DateTime ActivityEndTime { get; set; }
        public string ActivityImage { get; set; }
        public string ActivityBgColor { get; set; }
        public string ActivityContent { get; set; }
        /// <summary>
        /// 活動負責人
        /// </summary>
        public int PrincipalEmployee { get; set; }
        /// <summary>
        /// 活動上架時間(月初)
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// TRUE為刪除，FALSE為保留
        /// </summary>
        public bool IsDelete { get; set; }
    }
}
