using System.Collections.Generic;

namespace BSWebtoon.Front.Models.ViewModels.Rank
{
    public class RankViewModel
    {
        public RankData mainComic { get; set; }
        public IEnumerable<RankData> rankList { get; set; }
        public class RankData
        {
            public string ComicNameImage { get; set; }
            public string ComicFigure { get; set; }
            public string BgCover { get; set; }
            public string Introduction { get; set; }
        }
    }
}
