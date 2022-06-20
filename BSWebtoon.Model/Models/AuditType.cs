using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class AuditType
    {
        public AuditType()
        {
            Comics = new HashSet<Comic>();
        }

        public int AuditTypeId { get; set; }
        public string AuditTypeName { get; set; }

        public virtual ICollection<Comic> Comics { get; set; }
    }
}
