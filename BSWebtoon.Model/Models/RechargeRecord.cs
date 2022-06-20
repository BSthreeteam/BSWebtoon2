using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class RechargeRecord
    {
        public int RechargeRecordId { get; set; }
        public int MemberId { get; set; }
        public int? CashPlanId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int PayMethodId { get; set; }

        public virtual CashPlan CashPlan { get; set; }
        public virtual Member Member { get; set; }
        public virtual PayMethod PayMethod { get; set; }
    }
}
