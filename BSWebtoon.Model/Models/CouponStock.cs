using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class CouponStock
    {
        public CouponStock()
        {
            UseRecords = new HashSet<UseRecord>();
        }

        public int CouponStockId { get; set; }
        public int MemberId { get; set; }
        public int ComicId { get; set; }
        public int? StockQuantity { get; set; }

        public virtual Comic Comic { get; set; }
        public virtual Member Member { get; set; }
        public virtual ICollection<UseRecord> UseRecords { get; set; }
    }
}
