using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class Favorite
    {
        public int FavoriteId { get; set; }
        public int MemberId { get; set; }
        public int ComicId { get; set; }

        public virtual Comic Comic { get; set; }
        public virtual Member Member { get; set; }
    }
}
