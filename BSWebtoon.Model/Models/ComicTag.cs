﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class ComicTag
    {
        public ComicTag()
        {
            ComicTagLists = new HashSet<ComicTagList>();
        }

        public int TagId { get; set; }
        public string TagName { get; set; }
        public bool IsMainTag { get; set; }
        public bool IsDelete { get; set; }

        public virtual ICollection<ComicTagList> ComicTagLists { get; set; }
    }
}
