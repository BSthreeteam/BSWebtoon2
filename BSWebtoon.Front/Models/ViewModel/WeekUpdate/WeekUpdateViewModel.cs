using System.Collections.Generic;

namespace BSWebtoon.Front.Models.ViewModels.WeekUpdate
{
    public class WeekUpdateViewModel_Page
    {
        public IEnumerable<WeekUpdateData> ComicList { get; set; }

        public class WeekUpdateData
        {
            public int ComicId { get; set; }
            public string ComicNameImage { get; set; }
            public string BgCover { get; set; }
            public string ComicWeekFigure { get; set; }
            public int ComicStatus { get; set; }
            public int? UpdateWeek { get; set; }
            public string WeekVideoWrb { get; set; }
        }
    }
}
