using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class Episode
    {
        public Episode()
        {
            Comments = new HashSet<Comment>();
            CouponUsedRecords = new HashSet<CouponUsedRecord>();
            Coupons = new HashSet<Coupon>();
            EpContents = new HashSet<EpContent>();
        }

        public int EpId { get; set; }
        public int ComicId { get; set; }
        public string EpTitle { get; set; }
        public string EpCover { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime UploadTime { get; set; }
        public int AuditTypeId { get; set; }
        public int AuditEmployeeId { get; set; }
        public DateTime AuditTime { get; set; }
        public string AuditFailReason { get; set; }
        public bool IsCountdownCoupon { get; set; }
        public bool IsFree { get; set; }

        public virtual Employee AuditEmployee { get; set; }
        public virtual Comic Comic { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<CouponUsedRecord> CouponUsedRecords { get; set; }
        public virtual ICollection<Coupon> Coupons { get; set; }
        public virtual ICollection<EpContent> EpContents { get; set; }
    }
}
