using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Front.Models
{
    public partial class Rank
    {
        public int RankId { get; set; }
        public int ComicId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int ClickCount { get; set; }
        public int PreRank { get; set; }
    }
}
