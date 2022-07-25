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
        public string ComicChineseName { get; set; }
        public string ComicEnglishName { get; set; }
        public string ComicNameImage { get; set; }
        public string ComicFigure { get; set; }
        public string BgColor { get; set; }
        public string ComicWeekFigure { get; set; }
        public virtual Comic Comic { get; set; }
        public virtual Member Member { get; set; }
    }
}
