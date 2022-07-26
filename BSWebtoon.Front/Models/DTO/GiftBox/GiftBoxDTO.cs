using System;

namespace BSWebtoon.Front.Models.DTO.GiftBox
{
    public class GiftBoxDTO
    {
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public DateTime ActivityStartTime { get; set; }
        public DateTime ActivityEndTime { get; set; }
        public string ActivityImage { get; set; }
        public string ActivityBgColor { get; set; }
        public bool IsDelete { get; set; }
    }
}
