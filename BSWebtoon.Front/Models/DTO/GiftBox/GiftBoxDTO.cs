using System;
using System.Collections.Generic;

namespace BSWebtoon.Front.Models.DTO.GiftBox
{
    public class GiftBoxDTO
    {
        public List<GiftBoxItem> GiftBoxItems { get; set; }
        public class GiftBoxItem
        {
            public int ActivityId { get; set; }
            public string ActivityName { get; set; }
            public string ActivityImage { get; set; }
            public string ActivityBgColor { get; set; }
        }
    }
}
