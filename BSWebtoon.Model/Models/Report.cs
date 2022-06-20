using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class Report
    {
        public int ReportId { get; set; }
        public int CommentId { get; set; }
        public int BeReportedMemberId { get; set; }
        public int ReportMemberId { get; set; }
        public int ReportReasonId { get; set; }

        public virtual Member BeReportedMember { get; set; }
        public virtual Comment Comment { get; set; }
        public virtual Member ReportMember { get; set; }
        public virtual ReportReason ReportReason { get; set; }
    }
}
