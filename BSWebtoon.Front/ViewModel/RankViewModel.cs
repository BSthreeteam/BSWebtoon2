using System.Collections.Generic;

namespace BSWebtoon.Front.ViewModel
{
    public class RankViewModel
    {

        public int ComicId { get; set; }
        public string ComicName { get; set; }

        public string ComicNameImage { get; set; }
        public string ComicFigure { get; set; }
        public string BgCover { get; set; }
        public string BgColor { get; set; }
        public string Introduction { get; set; }
        public string BannerVideoWeb { get; set; }

        public string TagName { get; set; }
        public List<int> ClickCount { get; set; }






    }
}
