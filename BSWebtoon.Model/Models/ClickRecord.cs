using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class ClickRecord
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClickRecordId { get; set; }


        public int ComicId { get; set; }
        public DateTime CreateTime { get; set; }
        public int MemberId { get; set; }

        public virtual Member ClickRecordNavigation { get; set; }
        public virtual Comic Comic { get; set; }
    }
}
