using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class ViewRecord
    {
        public int EpId { get; set; }
        public int MemberId { get; set; }
        public int ComicId { get; set; }
        public string PeoplePic { get; set; }
        public string BgPic { get; set; }
        public int ComicPicId { get; set; }

        public virtual Comic Comic { get; set; }
        public virtual ComicPic ComicPic { get; set; }
        public virtual Epsiode Ep { get; set; }
        public virtual Member Member { get; set; }
    }
}
