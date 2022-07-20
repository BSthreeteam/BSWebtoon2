using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Front.Models
{
    public partial class Member
    {
        public Member()
        {
            ClickRecords = new HashSet<ClickRecord>();
            CommentLikeRecords = new HashSet<CommentLikeRecord>();
            Comments = new HashSet<Comment>();
            CouponUsedRecords = new HashSet<CouponUsedRecord>();
            Favorites = new HashSet<Favorite>();
            RechargeRecords = new HashSet<RechargeRecord>();
            ViewRecords = new HashSet<ViewRecord>();
        }

        public int MemberId { get; set; }
        public string NameIdentifier { get; set; }
        public string AccountName { get; set; }
        public string NickName { get; set; }
        public decimal Balance { get; set; }
        public int LoginTypeId { get; set; }
        public bool IsDarkTheme { get; set; }
        public DateTime CreateTime { get; set; }
        public string Email { get; set; }
        public string AccessToken { get; set; }

        public virtual LoginType LoginType { get; set; }
        public virtual ICollection<ClickRecord> ClickRecords { get; set; }
        public virtual ICollection<CommentLikeRecord> CommentLikeRecords { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<CouponUsedRecord> CouponUsedRecords { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<RechargeRecord> RechargeRecords { get; set; }
        public virtual ICollection<ViewRecord> ViewRecords { get; set; }
    }
}
