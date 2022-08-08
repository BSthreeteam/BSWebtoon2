using BSWebtoon.Front.Models.DTO.FavoriteDTO;
using BSWebtoon.Front.Models.DTO.WorkPage;
using System.Collections.Generic;

namespace BSWebtoon.Front.Service.FavoriteService
{
    public interface IFavoriteService
    {
        void FavoriteCreate();

        void FavoriteDelete();

        //void ReadFavorite();
        public List<FavoriteDTO> ReadFavorite(int id);
        void FavoriteDataCreateOrDelete(FavoriteDataDTO favoriteData);
    }
}
