using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class CashPlan
    {
        public CashPlan()
        {
            RechargeRecords = new HashSet<RechargeRecord>();
        }

        public int CashPlanId { get; set; }
        public string CashPlanName { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<RechargeRecord> RechargeRecords { get; set; }
    }
}
