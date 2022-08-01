using System.Collections.Generic;

namespace BSWebtoon.Front.Models.ViewModel.Favorite
{

    public class FavoriteViewModel
    {
        public IEnumerable<FavoriteData> FavoriteList { get; set; }
        public class FavoriteData
        {
            public int ComicId { get; set; }
            public string ComicNameImage { get; set; }
            public string ComicFigure { get; set; }
            public string BgColor { get; set; }
        }
    }
}
