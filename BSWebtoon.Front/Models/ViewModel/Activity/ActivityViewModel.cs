using System;
using System.Collections.Generic;

namespace BSWebtoon.Front.Models.ViewModel.Activity
{
    public class ActivityViewModel
    {
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public DateTime ActivityStartTime { get; set; }
        public DateTime ActivityEndTime { get; set; }
        public string ActivityImage { get; set; }
        public string ActivityBgColor { get; set; }
        public string ActivityContent { get; set; }
        public string PrincipalEmployee { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsDelete { get; set; }
    }
}
