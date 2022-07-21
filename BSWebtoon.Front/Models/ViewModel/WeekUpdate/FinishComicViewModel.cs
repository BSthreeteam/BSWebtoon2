using System.Collections.Generic;

namespace BSWebtoon.Front.Models.ViewModel.WeekUpdate
{
    public class FinishComicViewModel
    {

        public FinishComicBigData FinishComicBig { get; set; }
        public List<FinishComicData> FinishComicList { get; set; }

        public class FinishComicBigData
        {
            public int ComicId { get; set; }
            public string ComicNameImage { get; set; }
            public string BgCover { get; set; }
            public string ComicFigure { get; set; }
            public string Author { get; set; }
            public string Painter { get; set; }
            public string Introduction { get; set; }
        }
        public class FinishComicData
        {
            public int ComicId { get; set; }
            public string ComicNameImage { get; set; }
            public string BgCover { get; set; }
            public string ComicWeekFigure { get; set; }

        }

    }

}
