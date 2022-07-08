using System;

namespace BSWebtoon.Front.Models.DTO.Gift
{
    public class ActivityPageDTO
    {
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public DateTime ActivityStartTime { get; set; }
        public DateTime ActivityEndTime { get; set; }
        public string ActivityImage { get; set; }
        public string ActivityBgColor { get; set; }
        public string ActivityContent { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsDelete { get; set; }

    }
}
