using BSWebtoon.Front.Models.DTO.FavoriteDTO;
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
                new Favorite {MemberId = 1,ComicId =4},
                new Favorite {MemberId = 1,ComicId =5},
                new Favorite {MemberId = 1,ComicId =6},

                new Favorite {MemberId = 2,ComicId =2},
                new Favorite {MemberId = 2,ComicId =3},
                new Favorite {MemberId = 2,ComicId =4},
                new Favorite {MemberId = 2,ComicId =5},

                new Favorite {MemberId = 3,ComicId =2},
                new Favorite {MemberId = 3,ComicId =3},
                new Favorite {MemberId = 3,ComicId =4},
                new Favorite {MemberId = 3,ComicId =5},

                new Favorite {MemberId = 4,ComicId =5},
                new Favorite {MemberId = 4,ComicId =6},
                new Favorite {MemberId = 4,ComicId =7},
                new Favorite {MemberId = 4,ComicId =8},

                new Favorite {MemberId = 5,ComicId =6},
                new Favorite {MemberId = 5,ComicId =8},
                new Favorite {MemberId = 5,ComicId =9},
                new Favorite {MemberId = 5,ComicId =3},

            };
            foreach (Favorite favorite in favoriteList)
            {
                _repository.Create(favorite);
            }
            _repository.SaveChange();
        }

        public IEnumerable<FavoriteDTO> GetFavorite()
        {
            return from member in _repository.GetAll<Member>()
                   join comic in _repository.GetAll<Comic>()
                   on member.MemberId equals comic.ComicId
                   where member.MemberId == 1
                   select new FavoriteDTO
                   {
                       ComicFigure = comic.ComicFigure,
                       ComicNameImage = comic.ComicNameImage,
                       BgColor = comic.BgColor
                   };
        }
    }
}
