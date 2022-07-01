using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class LoginType
    {
        public LoginType()
        {
            Member = new HashSet<Member>();
        }

        public int LoginTypeId { get; set; }
        public string LoginTypeName { get; set; }

        public virtual ICollection<Member> Member { get; set; }
    }
}
