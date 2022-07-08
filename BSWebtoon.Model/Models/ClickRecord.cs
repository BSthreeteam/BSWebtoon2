using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class ClickRecord
    {
        public int ClickRecordId { get; set; }
        public int ComicId { get; set; }
        public DateTime CreateTime { get; set; }
        public int MemberId { get; set; }

        public virtual Member ClickRecordNavigation { get; set; }
        public virtual Comic Comic { get; set; }

        public int FirstOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
