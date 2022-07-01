using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class Member
    {
        public Member()
        {
            CommentLikeRecord = new HashSet<CommentLikeRecord>();
            Comment = new HashSet<Comment>();
            CouponUsedRecord = new HashSet<CouponUsedRecord>();
            Favorite = new HashSet<Favorite>();
            RechargeRecord = new HashSet<RechargeRecord>();
            ViewRecord = new HashSet<ViewRecord>();
        }

        public int MemberId { get; set; }
        public string AccountName { get; set; }
        public string NickName { get; set; }
        public decimal Balance { get; set; }
        public int LoginTypeId { get; set; }
        public bool IsDarkTheme { get; set; }
        public DateTime CreateTime { get; set; }
        public string Email { get; set; }
        public string AccessToken { get; set; }

        public virtual LoginType LoginType { get; set; }
        public virtual ClickRecord ClickRecord { get; set; }
        public virtual ICollection<CommentLikeRecord> CommentLikeRecord { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<CouponUsedRecord> CouponUsedRecord { get; set; }
        public virtual ICollection<Favorite> Favorite { get; set; }
        public virtual ICollection<RechargeRecord> RechargeRecord { get; set; }
        public virtual ICollection<ViewRecord> ViewRecord { get; set; }
    }
}
