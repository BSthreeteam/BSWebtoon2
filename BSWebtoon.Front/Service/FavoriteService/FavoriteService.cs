using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System.Collections.Generic;

namespace BSWebtoon.Front.Service.FavoriteService
{
    
    public class FavoriteService : IFavoriteService
    {
        private readonly BSRepository _repository;

        public FavoriteService(BSRepository repository)
        {
            _repository = repository;
        }

        public void FavoriteCreate()
        {
            var favoriteList = new List<Favorite>
            {
                new Favorite {MemberId = 1,ComicId =1},
                new Favorite {MemberId = 2,ComicId =2},
            };
            foreach(Favorite favorite in favoriteList)
            {
                _repository.Create(favorite);
            }
            _repository.SaveChange();
        }
    }
}
