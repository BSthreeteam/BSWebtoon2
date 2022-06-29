using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class ComicTagList
    {
        public int TageListId { get; set; }
        public int TagId { get; set; }
        public int ComicId { get; set; }

        public virtual Comic Comic { get; set; }
        public virtual ComicTag Tag { get; set; }
    }
}
