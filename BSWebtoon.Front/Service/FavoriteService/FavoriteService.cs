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

        public List<FavoriteDTO> ReadFavorite(int id)
        {
            var favoritList = _repository.GetAll<Favorite>().Where(f => f.MemberId == id);
            //var MemberIdList = _repository.GetAll<Member>().OrderBy(e => e.MemberId);
            var ComicIdList = _repository.GetAll<Comic>();
            //var favoritList = _repository.GetAll<Favorite>().Where(c => c.FavoriteId == FavoriteId).First();
            var result = new List<FavoriteDTO>();

            List<FavoriteDTO> FavoritList = favoritList.Select(f => new FavoriteDTO
            {
                FavoriteId = f.FavoriteId,
                MemberId = f.MemberId,
                ComicId = f.ComicId,
                ComicChineseName = _repository.GetAll<Comic>().SingleOrDefault(c => c.ComicId == f.ComicId).ComicChineseName,
                ComicEnglishName = _repository.GetAll<Comic>().SingleOrDefault(c => c.ComicId == f.ComicId).ComicEnglishName,
                ComicNameImage = _repository.GetAll<Comic>().SingleOrDefault(c => c.ComicId == f.ComicId).ComicNameImage,
                ComicFigure = _repository.GetAll<Comic>().SingleOrDefault(c => c.ComicId == f.ComicId).ComicFigure,
                BgColor = _repository.GetAll<Comic>().SingleOrDefault(c => c.ComicId == f.ComicId).BgColor,
                ComicWeekFigure = _repository.GetAll<Comic>().SingleOrDefault(c => c.ComicId == f.ComicId).ComicWeekFigure,
            }).ToList();
            result.AddRange(FavoritList);

            return result;
        }


        //public List<FavoriteDTO> ReadFavorite(int id)
        //{
        //    var favoritList = _repository.GetAll<Favorite>().Where(f => f.MemberId == id);
        //    //var MemberIdList = _repository.GetAll<Member>().OrderBy(e => e.MemberId);
        //    var ComicIdList = _repository.GetAll<Comic>();
        //    //var favoritList = _repository.GetAll<Favorite>().Where(c => c.FavoriteId == FavoriteId).First();
        //    var result = new List<FavoriteDTO>();

        //    List<FavoriteDTO> FavoritList = favoritList.Select(f => new FavoriteDTO
        //    {
        //        FavoriteId = f.FavoriteId,
        //        MemberId = f.MemberId,
        //        ComicId = f.ComicId,
        //        ComicChineseName = _repository.GetAll<Comic>().SingleOrDefault(c => c.ComicId == f.ComicId).ComicChineseName,
        //        ComicEnglishName = _repository.GetAll<Comic>().SingleOrDefault(c => c.ComicId == f.ComicId).ComicEnglishName,
        //        ComicNameImage = _repository.GetAll<Comic>().SingleOrDefault(c => c.ComicId == f.ComicId).ComicNameImage,
        //        ComicFigure = _repository.GetAll<Comic>().SingleOrDefault(c => c.ComicId == f.ComicId).ComicFigure,
        //        BgColor = _repository.GetAll<Comic>().SingleOrDefault(c => c.ComicId == f.ComicId).BgColor,
        //        ComicWeekFigure = _repository.GetAll<Comic>().SingleOrDefault(c => c.ComicId == f.ComicId).ComicWeekFigure,
        //    }).ToList();
        //    result.AddRange(FavoritList);

        //    return result;
        //}


        //public IEnumerable<FavoriteDTO> GetFavorite()
        //{
        //    return from member in _repository.GetAll<Member>()
        //           join comic in _repository.GetAll<Comic>()
        //           on member.MemberId equals comic.ComicId
        //           where member.MemberId == 1
        //           select new FavoriteDTO
        //           {
        //               ComicFigure = comic.ComicFigure,
        //               ComicNameImage = comic.ComicNameImage,
        //               BgColor = comic.BgColor
        //           };
        //}



        public void FavoriteDelete()
        {
            var p2 = _repository.GetAll<Favorite>().Where(f => f.MemberId == 1).FirstOrDefault();
            _repository.Delete(p2);
            _repository.SaveChange();
        }


    }
}
