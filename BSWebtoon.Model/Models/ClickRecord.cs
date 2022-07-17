using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class ClickRecord
    {
        public int ClickRecordId { get; set; }
        public int ComicId { get; set; }
        public DateTime CreateTime { get; set; }
        public int MemberId { get; set; }

        public virtual Comic Comic { get; set; }
        public virtual Member Member { get; set; }
    }
}
