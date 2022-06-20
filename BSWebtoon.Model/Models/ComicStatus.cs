using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class ComicStatus
    {
        public ComicStatus()
        {
            Comics = new HashSet<Comic>();
        }

        public int ComicStatusId { get; set; }
        public string ComicStatusName { get; set; }

        public virtual ICollection<Comic> Comics { get; set; }
    }
}
