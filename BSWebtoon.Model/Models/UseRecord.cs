using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class UseRecord
    {
        public int UseRecordId { get; set; }
        public int MemberId { get; set; }
        public int EpId { get; set; }
        public int CouponStockId { get; set; }
        public DateTime UseDateSart { get; set; }
        public DateTime UseDateEnd { get; set; }
        public int Quantity { get; set; }

        public virtual CouponStock CouponStock { get; set; }
        public virtual Epsiode Ep { get; set; }
        public virtual Member Member { get; set; }
    }
}
