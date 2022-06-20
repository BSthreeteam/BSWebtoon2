using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class Comic
    {
        public Comic()
        {
            ComicPics = new HashSet<ComicPic>();
            Comments = new HashSet<Comment>();
            CouponStocks = new HashSet<CouponStock>();
            Epsiodes = new HashSet<Epsiode>();
            GetTicketMethods = new HashSet<GetTicketMethod>();
        }

        public int ComicId { get; set; }
        public string ComicName { get; set; }
        public string NamePic { get; set; }
        public string BgPic { get; set; }
        public string PeoplePic { get; set; }
        public string Bgc { get; set; }
        public DateTime PublishDate { get; set; }
        public int UpdateWeek { get; set; }
        public string Publisher { get; set; }
        public string Introduction { get; set; }
        public int? ComicStatusId { get; set; }
        public string TitleVideoWeb { get; set; }
        public string TitleVideoMp4 { get; set; }
        public string ComicVideoWeb { get; set; }
        public string ComicVideoMp4 { get; set; }
        public string Author { get; set; }
        public int AuditTypeId { get; set; }
        public int? Rank { get; set; }
        public string FailureCheckReason { get; set; }

        public virtual AuditType AuditType { get; set; }
        public virtual ComicStatus ComicStatus { get; set; }
        public virtual ICollection<ComicPic> ComicPics { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<CouponStock> CouponStocks { get; set; }
        public virtual ICollection<Epsiode> Epsiodes { get; set; }
        public virtual ICollection<GetTicketMethod> GetTicketMethods { get; set; }
    }
}
