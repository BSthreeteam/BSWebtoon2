using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class Epsiode
    {
        public Epsiode()
        {
            ComicPics = new HashSet<ComicPic>();
            Comments = new HashSet<Comment>();
            Orders = new HashSet<Order>();
            UseRecords = new HashSet<UseRecord>();
        }

        public int EpId { get; set; }
        public int ComicId { get; set; }
        public string EpTitle { get; set; }
        public int? ClickCount { get; set; }
        public int Epimg { get; set; }
        public string UpdateDate { get; set; }
        public int AuditTypeId { get; set; }
        public string FailureCheckReason { get; set; }

        public virtual Comic Comic { get; set; }
        public virtual ICollection<ComicPic> ComicPics { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<UseRecord> UseRecords { get; set; }
    }
}
