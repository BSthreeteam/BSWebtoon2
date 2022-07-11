using System;

namespace BSWebtoon.Front.Models.ViewModel.WeekUpdate
{
    public class NewComicViewModel
    {
        public int ComicId { get; set; }
        public string ComicNameImage { get; set; }
        public string BgCover { get; set; }
        public string ComicFigure { get; set; }
        public string Author { get; set; }
        public string Painter { get; set; }
        public string Introduction { get; set; }
        public DateTime PublishDate { get; set; }

    }
}
