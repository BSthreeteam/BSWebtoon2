using System;
using System.Collections.Generic;

namespace BSWebtoon.Front.Models.ViewModel.WeekUpdate
{
    public class WeekUpdateViewModel
    {
        public int WeekDay { get; set; }
        public List<WeekUpdateDataLing> WeekComicLongList { get; set; }
        public List<WeekUpdateData> WeekComicList { get; set; }

        public class WeekUpdateDataLing
        {
            public int ComicId { get; set; }
            public string ComicNameImage { get; set; }
            public string BgCover { get; set; }
            public int ComicStatus { get; set; }
            public int? UpdateWeek { get; set; }
            public string WeekVideoWrb { get; set; }
        }
        public class WeekUpdateData
        {
            public int ComicId { get; set; }
            public string ComicNameImage { get; set; }
            public string BgCover { get; set; }
            public string ComicWeekFigure { get; set; }
            public int ComicStatus { get; set; }
            public int? UpdateWeek { get; set; }
        }
    }
}
