using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Front.Models
{
    public partial class LoginType
    {
        public LoginType()
        {
            Members = new HashSet<Member>();
        }

        public int LoginTypeId { get; set; }
        public string LoginTypeName { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}
