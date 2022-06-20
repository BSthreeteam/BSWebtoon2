using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class ReportReason
    {
        public ReportReason()
        {
            Reports = new HashSet<Report>();
        }

        public int ReportReasonId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Report> Reports { get; set; }
    }
}
