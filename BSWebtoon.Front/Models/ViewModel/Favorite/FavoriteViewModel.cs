using System.Collections.Generic;

namespace BSWebtoon.Front.Models.ViewModel.Favorite
{
    public class FavoriteViewModel
    {
        public List<FavoriteData> FavoriteList { get; set; }
        //public class FavoriteData
        //{
        public class FavoriteData
        {
        public int FavoriteId { get; set; }
        public int MemberId { get; set; }
        public int ComicId { get; set; }
        public string ComicChineseName { get; set; }
        public string ComicEnglishName { get; set; }
        public string ComicNameImage { get; set; }
        public string ComicFigure { get; set; }
        public string BgColor { get; set; }
        public string ComicWeekFigure { get; set; }

        }
        //}
    }
}
