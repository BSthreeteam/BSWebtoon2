using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class Member
    {
        public Member()
        {
            CouponStocks = new HashSet<CouponStock>();
            Orders = new HashSet<Order>();
            RechargeRecords = new HashSet<RechargeRecord>();
            ReportBeReportedMembers = new HashSet<Report>();
            ReportReportMembers = new HashSet<Report>();
            UseRecords = new HashSet<UseRecord>();
        }

        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public decimal? Balance { get; set; }
        public int LoginTypeId { get; set; }
        public bool Setting { get; set; }

        public virtual LoginType LoginType { get; set; }
        public virtual ICollection<CouponStock> CouponStocks { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<RechargeRecord> RechargeRecords { get; set; }
        public virtual ICollection<Report> ReportBeReportedMembers { get; set; }
        public virtual ICollection<Report> ReportReportMembers { get; set; }
        public virtual ICollection<UseRecord> UseRecords { get; set; }
    }
}
