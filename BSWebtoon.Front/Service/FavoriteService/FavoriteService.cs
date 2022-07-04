using BSWebtoon.Front.ViewModels;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System.Collections.Generic;
using System.Linq;

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

        public IEnumerable<FavoriteViewModel> GetFavorite()
        {
            return from member in _repository.GetAll<Member>()
                   join comic in _repository.GetAll<Comic>()
                   on member.MemberId equals comic.ComicId
                   where member.MemberId == 1
                   select new FavoriteViewModel
                   {
                       ComicFigure = comic.ComicFigure,
                       ComicNameImage = comic.ComicNameImage,
                       BgColor = comic.BgColor
                   };
        }
    }
}
