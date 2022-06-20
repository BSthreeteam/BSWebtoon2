using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int MemberId { get; set; }
        public int GetId { get; set; }
        public int EpId { get; set; }
        public int CouponStockId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int? StockQuantity { get; set; }

        public virtual Epsiode Ep { get; set; }
        public virtual Member Member { get; set; }
    }
}
