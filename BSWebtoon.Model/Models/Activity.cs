using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class Activity
    {
        public Activity()
        {
            Coupon = new HashSet<Coupon>();
        }

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

        public virtual Employee PrincipalEmployeeNavigation { get; set; }
        public virtual ICollection<Coupon> Coupon { get; set; }
    }
}
