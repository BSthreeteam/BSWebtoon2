using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class CouponUsedRecord
    {
        public int CouponRecordId { get; set; }
        public int MemberId { get; set; }
        public int EpId { get; set; }
        public int CouponId { get; set; }
        public DateTime StartReadTime { get; set; }
        public DateTime EndReadTime { get; set; }

        public virtual Coupon Coupon { get; set; }
        public virtual Episode Ep { get; set; }
        public virtual Member Member { get; set; }
    }
}
