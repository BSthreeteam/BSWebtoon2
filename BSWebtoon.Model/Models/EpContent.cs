using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class EpContent
    {
        public int EpContentId { get; set; }
        public int EpId { get; set; }
        public string ImagePath { get; set; }
        public int Page { get; set; }

        public virtual Episode Ep { get; set; }
    }
}
