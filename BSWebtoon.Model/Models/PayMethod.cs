using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class PayMethod
    {
        public PayMethod()
        {
            RechargeRecords = new HashSet<RechargeRecord>();
        }

        public int PayMethodId { get; set; }
        public string PayMethodName { get; set; }
        public bool PayMethodtype { get; set; }

        public virtual ICollection<RechargeRecord> RechargeRecords { get; set; }
    }
}
