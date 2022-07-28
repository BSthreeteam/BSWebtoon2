using System.Collections.Generic;

namespace BSWebtoon.Front.Models.ViewModel.GiftBox
{
    public class GiftBoxViewModel
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
