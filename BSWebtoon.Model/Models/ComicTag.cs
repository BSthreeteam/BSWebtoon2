using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class ComicTag
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public bool IsMainTag { get; set; }
        public bool IsDelete { get; set; }
        public int AuditEmployeeId { get; set; }
        public DateTime? AuditDate { get; set; }
    }
}
