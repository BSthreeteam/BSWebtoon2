using System.Collections.Generic;

namespace BSWebtoon.Front.Models.ViewModel.Recommend
{
    public class RecommendViewModel
    {
        public IEnumerable<RecommendData> RecommendList { get; set; }

        public class RecommendData
        {
            public string ComicNameImage { get; set; }
            public string ComicFigure { get; set; }
            public string Introduction { get; set; }
            public string BgCover { get; set; }
        }
    }
}
