using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class CashPlan
    {
        public CashPlan()
        {
            RechargeRecord = new HashSet<RechargeRecord>();
        }

        public int CashPlanId { get; set; }
        public string CashPlanContent { get; set; }
        public decimal Price { get; set; }
        public int Sort { get; set; }
        public bool IsEnable { get; set; }

        public virtual ICollection<RechargeRecord> RechargeRecord { get; set; }
    }
}
