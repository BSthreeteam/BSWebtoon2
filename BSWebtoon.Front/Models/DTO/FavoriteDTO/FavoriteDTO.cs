namespace BSWebtoon.Front.Models.DTO.FavoriteDTO
{
    public class FavoriteDTO
    {
        public int ComicId { get; set; }
        public int FavoriteId { get; set; }
        public int MemberId { get; set; }
        public string ComicChineseName { get; set; }
        public string ComicEnglishName { get; set; }
        public string ComicNameImage { get; set; }
        public string ComicFigure { get; set; }
        public string BgColor { get; set; }
        public string ComicWeekFigure { get; set; }
    }
}
