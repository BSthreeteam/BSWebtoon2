using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Front.Models
{
    public partial class Payment
    {
        public Payment()
        {
            RechargeRecords = new HashSet<RechargeRecord>();
        }

        public int PaymentId { get; set; }
        public string PaymentName { get; set; }
        public bool IsEnable { get; set; }
        public int Sort { get; set; }

        public virtual ICollection<RechargeRecord> RechargeRecords { get; set; }
    }
}
