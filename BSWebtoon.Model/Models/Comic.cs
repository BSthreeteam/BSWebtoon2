using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class Comic
    {
        public Comic()
        {
            ClickRecords = new HashSet<ClickRecord>();
            ComicTagLists = new HashSet<ComicTagList>();
            Coupons = new HashSet<Coupon>();
            Episodes = new HashSet<Episode>();
            Favorites = new HashSet<Favorite>();
        }

        public int ComicId { get; set; }
        public string ComicChineseName { get; set; }
        public string ComicEnglishName { get; set; }
        public string ComicNameImage { get; set; }
        public string HotComicNameImage { get; set; }
        public string BgCover { get; set; }
        public string HotBgCover { get; set; }
        public string ComicFigure { get; set; }
        public string ComicWeekFigure { get; set; }
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
        public string WeekVideoWrb { get; set; }
        public string ComicVideoWeb { get; set; }
        public string HotVideo { get; set; }
        public int AuditType { get; set; }
        public int AuditEmployeeId { get; set; }
        public string AuditFailReason { get; set; }
        public DateTime? AuditTime { get; set; }
        public int ComicStatus { get; set; }

        public virtual Employee AuditEmployee { get; set; }
        public virtual ICollection<ClickRecord> ClickRecords { get; set; }
        public virtual ICollection<ComicTagList> ComicTagLists { get; set; }
        public virtual ICollection<Coupon> Coupons { get; set; }
        public virtual ICollection<Episode> Episodes { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
    }
}
