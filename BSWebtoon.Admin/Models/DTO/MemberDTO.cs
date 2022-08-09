using BSWebtoon.Model.Models;
using System;

namespace BSWebtoon.Admin.Models.DTO
{
    public class MemberDTO:Member
    {
        public string LoginTypeName { get; set; }
    }
}
