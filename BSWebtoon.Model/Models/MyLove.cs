using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class MyLove
    {
        public int MemberId { get; set; }
        public int ComicId { get; set; }
        public string NamePic { get; set; }
        public string PeoplePic { get; set; }
        public string BgcPic { get; set; }
        public string Bell { get; set; }

        public virtual Comic Comic { get; set; }
        public virtual Member Member { get; set; }
    }
}
