using System.Collections.Generic;

namespace BSWebtoon.Front.Models.DTO.Recommend
{
    public class HitWorkDTO
    {
        public List<HitWorkComic> HitWorkComics { get; set; }
        public class HitWorkComic
        {
            public int ComicId { get; set; }
            public string ComicChineseName { get; set; }
            public string HotComicNameImage { get; set; }
            public string HotBgCover { get; set; }
            public string HotVideo { get; set; }

        }
    }
}
