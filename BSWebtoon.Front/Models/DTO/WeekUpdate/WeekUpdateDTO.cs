using System.Collections.Generic;

namespace BSWebtoon.Front.Models.DTO.WeekUpDate
{
    public class WeekUpDateDTO
    {
        public int WeekDay { get; set; }
        public List<WeekDayComic> WeekUpDateList { get; set; }
    }
    public class WeekDayComic
    {
        public int ComicId { get; set; }
        public string ComicNameImage { get; set; }
        public string BgCover { get; set; }
        public string ComicWeekFigure { get; set; }
        public int ComicStatus { get; set; }
        public int? UpdateWeek { get; set; }
        public string WeekVideoWrb { get; set; }
        public int ViewCount { get; set; }

    }
}
