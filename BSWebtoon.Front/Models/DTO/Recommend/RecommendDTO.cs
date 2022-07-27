using System.Collections.Generic;

namespace BSWebtoon.Front.Models.DTO.Recommend
{
    public class RecommendDTO
    {
        public List<RecommendComic> RecommendComics { get; set; }
        public class RecommendComic
        {
            public int ComicId { get; set; }
            public string RecommendTag { get; set; }
            public string Introduction { get; set; }
            public string Name { get; set; }
            public string NameImage { get; set; }
            public string ComicBgCover { get; set; }
            public string ActivityBgColor { get; set; }
            public string BannerVideoWeb { get; set; }
            public string ComicFigure { get; set; }
            public string ActivityImage { get; set; }
            public string ControllerName { get; set; }
            public string ActionName { get; set; }
        }
    }
}
