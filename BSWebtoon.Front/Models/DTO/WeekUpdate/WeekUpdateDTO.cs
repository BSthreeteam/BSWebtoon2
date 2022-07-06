using System;

namespace BSWebtoon.Front.Models.DTO.WeekUpdate
{
    public class WeekUpdateDTO
    {
        public int ComicId { get; set; }
        public string ComicChineseName { get; set; }
        public string ComicEnglishName { get; set; }
        public string ComicNameImage { get; set; }
        public string ComicFigure { get; set; }
        public string ComicWeekFigure { get; set; }
        public string BgCover { get; set; }
        public string WeekVideoWrb { get; set; }
        public int ComicStatus { get; set; }
        public DateTime PublishDate { get; set; }
        public int UpdateWeek { get; set; }



    }
}
