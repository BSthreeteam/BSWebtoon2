using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class LoginType
    {
        public LoginType()
        {
            Members = new HashSet<Member>();
        }

        public int LoginTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}
