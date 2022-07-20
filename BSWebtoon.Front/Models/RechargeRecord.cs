using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Front.Models
{
    public partial class RechargeRecord
    {
        public int RechargeRecordId { get; set; }
        public int MemberId { get; set; }
        public int? CashPlanId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int PaymentId { get; set; }
        public int CashPlanContent { get; set; }
        public int Price { get; set; }
        public int PayState { get; set; }

        public virtual CashPlan CashPlan { get; set; }
        public virtual Member Member { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
