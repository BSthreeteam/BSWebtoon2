using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class ComicPic
    {
        public int ComicPicId { get; set; }
        public int EpId { get; set; }
        public int ComicId { get; set; }
        public string Jpg { get; set; }
        public int Sort { get; set; }

        public virtual Comic Comic { get; set; }
        public virtual Epsiode Ep { get; set; }
    }
}
