using BSWebtoon.Front.Models.DTO.FavoriteDTO;
using BSWebtoon.Front.Models.DTO.WorkPage;
using System.Collections.Generic;

namespace BSWebtoon.Front.Service.FavoriteService
{
    public interface IFavoriteService
    {
        void FavoriteCreate();

        void FavoriteDelete(int id);

        //void ReadFavorite();
        List<FavoriteDTO> ReadFavorite(int id);

        void RemoveFavoriteRecord(RemoveFavoriteInputDTO input);
        void FavoriteDataCreateOrDelete(FavoriteDataDTO favoriteData);
    }
}
