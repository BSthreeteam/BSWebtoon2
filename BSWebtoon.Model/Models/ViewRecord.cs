using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class ViewRecord
    {
        public int ViewRecorId { get; set; }
        public int MemberId { get; set; }
        public int EpId { get; set; }
        public DateTime ViewTime { get; set; }
        public bool IsDelete { get; set; }

        public virtual Episode Ep { get; set; }
        public virtual Member Member { get; set; }
    }
}
