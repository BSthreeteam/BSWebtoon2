using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class Comic
    {
        public Comic()
        {
            ClickRecord = new HashSet<ClickRecord>();
            Coupon = new HashSet<Coupon>();
            Episode = new HashSet<Episode>();
            Favorite = new HashSet<Favorite>();
            //Rank = new HashSet<Rank>();
        }

        public int ComicId { get; set; }
        public string ComicName { get; set; }
        public string ComicNameImage { get; set; }
        public string BgCover { get; set; }
        public string ComicFigure { get; set; }
        public string BgColor { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime LastPublishDate { get; set; }
        public DateTime? FinallyPublishDate { get; set; }
        public int? UpdateWeek { get; set; }
        public string Publisher { get; set; }
        public string Painter { get; set; }
        public string Author { get; set; }
        public string Introduction { get; set; }
        public string BannerVideoWeb { get; set; }
        public string BannerVideoMp4 { get; set; }
        public string ComicVideoWeb { get; set; }
        public string ComicVideoMp4 { get; set; }
        public int AuditType { get; set; }
        public int AuditEmployeeId { get; set; }
        public string AuditFailReason { get; set; }
        public DateTime? AuditTime { get; set; }
        public int ComicStatus { get; set; }

        public virtual Employee AuditEmployee { get; set; }
        public virtual ICollection<ClickRecord> ClickRecord { get; set; }
        public virtual ICollection<Coupon> Coupon { get; set; }
        public virtual ICollection<Episode> Episode { get; set; }
        public virtual ICollection<Favorite> Favorite { get; set; }
        //public virtual ICollection<Rank> Rank { get; set; }
    }
}
