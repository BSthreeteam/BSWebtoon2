using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class Episode
    {
        public Episode()
        {
            Comment = new HashSet<Comment>();
            CouponUsedRecord = new HashSet<CouponUsedRecord>();
            Coupon = new HashSet<Coupon>();
            EpContent = new HashSet<EpContent>();
        }

        public int EpId { get; set; }
        public int ComicId { get; set; }
        public string EpTitle { get; set; }
        /// <summary>
        /// 話次封面
        /// </summary>
        public string EpCover { get; set; }
        /// <summary>
        /// 更新時間
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 作者上傳時間
        /// </summary>
        public DateTime UploadTime { get; set; }
        /// <summary>
        /// 1:審核通過,2:審核中,3:未審核,4:審核失敗
        /// </summary>
        public int AuditTypeId { get; set; }
        public int AuditEmployeeId { get; set; }
        public DateTime AuditTime { get; set; }
        public string AuditFailReason { get; set; }
        public bool IsCountdownCoupon { get; set; }
        public bool IsFree { get; set; }

        public virtual Employee AuditEmployee { get; set; }
        public virtual Comic Comic { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<CouponUsedRecord> CouponUsedRecord { get; set; }
        public virtual ICollection<Coupon> Coupon { get; set; }
        public virtual ICollection<EpContent> EpContent { get; set; }
    }
}
