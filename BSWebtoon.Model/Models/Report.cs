using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class Report
    {
        public int ReportId { get; set; }
        public int CommentId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? AuditType { get; set; }
        public int? AuditEmployeeId { get; set; }
        public DateTime? AuditTime { get; set; }
        public string Reason { get; set; }

        public virtual Employee AuditEmployee { get; set; }
        public virtual Comment Comment { get; set; }
    }
}
