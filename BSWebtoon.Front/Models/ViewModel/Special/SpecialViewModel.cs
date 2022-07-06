using System.Collections.Generic;

namespace BSWebtoon.Front.Models.ViewModel.Special
{
    public class SpecialViewModel
    {
        public IEnumerable<SpecialData> specialList { get; set; }

        public class SpecialData
        {
            public string HotBgCover { get; set; }
            public string HotVideo { get; set; }
            public string HotComicNameImage { get; set; }
        }

    }
}
