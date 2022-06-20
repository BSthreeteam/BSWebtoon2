using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class KeywordConnect
    {
        public int KeywordDetailId { get; set; }
        public int ComicId { get; set; }

        public virtual Comic Comic { get; set; }
        public virtual KeywordDetail KeywordDetail { get; set; }
    }
}
