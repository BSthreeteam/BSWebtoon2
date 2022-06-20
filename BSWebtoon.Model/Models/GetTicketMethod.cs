using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class GetTicketMethod
    {
        public int GetTicketMethodId { get; set; }
        public string GetTicketMethodName { get; set; }
        public DateTime? GetTicketMethodStartDate { get; set; }
        public DateTime? GetTicketMethodEndDate { get; set; }
        public int? ComicId { get; set; }

        public virtual Comic Comic { get; set; }
    }
}
