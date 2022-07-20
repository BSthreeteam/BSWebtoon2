using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Front.Models
{
    public partial class ViewRecord
    {
        public int ViewRecorId { get; set; }
        public int MemberId { get; set; }
        public int EpContentId { get; set; }
        public DateTime ViewTime { get; set; }
        public bool IsDelete { get; set; }

        public virtual EpContent EpContent { get; set; }
        public virtual Member Member { get; set; }
    }
}
