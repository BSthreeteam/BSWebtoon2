using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class Coupon
    {
        public Coupon()
        {
            CouponUsedRecord = new HashSet<CouponUsedRecord>();
        }

        public int CouponId { get; set; }
        public int MemberId { get; set; }
        public int? ComicId { get; set; }
        public int? ActivityId { get; set; }
        public int CouponTypeId { get; set; }
        public int OriginQuantity { get; set; }
        public DateTime CreateTime { get; set; }
        public int Quantity { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Episode ActivityNavigation { get; set; }
        public virtual Comic Comic { get; set; }
        public virtual ICollection<CouponUsedRecord> CouponUsedRecord { get; set; }
    }
}
