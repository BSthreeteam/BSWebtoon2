using System;
using System.Collections.Generic;

namespace BSWebtoon.Front.Models.DTO.WeekUpDate
{
    public class NewComicDTO
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
