namespace BSWebtoon.Front.Models.DTO
{
    public class RecommendDTO
    {
        public int ComicId { get; set; }
        public string ComicNameImage { get; set; }
        public string ComicEnglishName { get; set; }

        public string ComicFigure { get; set; }
        public string Introduction { get; set; }
        public string BgCover { get; set; }
        public int ComicStatus { get; set; }

        //public int Popularity { get; set; }//人氣

    }
}
