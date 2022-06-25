using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class Activity
    {
        public Activity()
        {
            Coupons = new HashSet<Coupon>();
        }

        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public DateTime ActivityStartTime { get; set; }
        public DateTime ActivityEndTime { get; set; }
        public string ActivityImage { get; set; }
        public string ActivityBgColor { get; set; }
        public string ActivityContent { get; set; }
        public int PrincipalEmployee { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsDelete { get; set; }

        public virtual Employee PrincipalEmployeeNavigation { get; set; }
        public virtual ICollection<Coupon> Coupons { get; set; }
    }
}
