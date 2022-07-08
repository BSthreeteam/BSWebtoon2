using System.Collections.Generic;

namespace BSWebtoon.Front.Models.ViewModel.Gift
{
    public class GiftViewModel
    {
        public IEnumerable<ActivityData> Activity { get; set; }
        public class ActivityData
        {
            public int ActivityId { get; set; }
            public string ActivityName { get; set; }
            public string ActivityImage { get; set; }
        }
    }
}
