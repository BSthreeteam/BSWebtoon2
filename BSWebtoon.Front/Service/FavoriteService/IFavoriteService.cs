using BSWebtoon.Front.Models.DTO.FavoriteDTO;
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



    }
}
