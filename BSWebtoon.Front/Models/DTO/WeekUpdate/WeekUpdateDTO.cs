namespace BSWebtoon.Front.Models.DTO.WeekUpData
{
    public class WeekUpDateDTO
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
