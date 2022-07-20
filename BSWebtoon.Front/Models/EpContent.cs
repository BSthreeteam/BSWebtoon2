using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Front.Models
{
    public partial class EpContent
    {
        public EpContent()
        {
            ViewRecords = new HashSet<ViewRecord>();
        }

        public int EpContentId { get; set; }
        public int EpId { get; set; }
        public string ImagePath { get; set; }
        public int Page { get; set; }

        public virtual Episode Ep { get; set; }
        public virtual ICollection<ViewRecord> ViewRecords { get; set; }
    }
}
