using System;

namespace BSWebtoon.Admin.Models.ViewModel
{
    public class UploadComicViewModel
    {
        public string ComicChineseName { get; set; }
        public string ComicEnglishName { get; set; }
        public string ComicNameImage { get; set; }
        public string BgCover { get; set; }
        public string ComicFigure { get; set; }
        public string ComicWeekFigure { get; set; }
        public string BgColor { get; set; }
        public DateTime PublishDate { get; set; }
        public int? UpdateWeek { get; set; }
        public string Painter { get; set; }
        public string Author { get; set; }
        public string Introduction { get; set; }
        public int? AuditEmployeeId { get; set; }
    }
}
