using BSWebtoon.Front.Models.DTO.FavoriteDTO;
using BSWebtoon.Front.Models.DTO.WorkPage;
using BSWebtoon.Front.Service.MemberService;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BSWebtoon.Front.Service.FavoriteService
{

    public class FavoriteService : IFavoriteService
    {
        private readonly BSRepository _repository;
        private readonly IMemberService _memberService;

        public FavoriteService(BSRepository repository, IMemberService memberService)
        {
            _repository = repository;
            _memberService = memberService;
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

        public List<FavoriteDTO> ReadFavorite()
        {
            var memberId = _memberService.GetCurrentMemberID();

            var favoritList = _repository.GetAll<Favorite>().Where(f => f.MemberId == memberId);
            //var MemberIdList = _repository.GetAll<Member>().OrderBy(e => e.MemberId);
            var ComicIdList = _repository.GetAll<Comic>();
            //var favoritList = _repository.GetAll<Favorite>().Where(c => c.FavoriteId == FavoriteId).First();
            var result = new List<FavoriteDTO>();


            List<FavoriteDTO> FavoritList = favoritList.Select(f => new FavoriteDTO
            {
                FavoriteId = f.FavoriteId,
                MemberId = f.MemberId,
                ComicId = f.ComicId,
                ComicChineseName = ComicIdList.SingleOrDefault(c => c.ComicId == f.ComicId).ComicChineseName,
                ComicEnglishName = ComicIdList.SingleOrDefault(c => c.ComicId == f.ComicId).ComicEnglishName,
                ComicNameImage = ComicIdList.SingleOrDefault(c => c.ComicId == f.ComicId).ComicNameImage,
                ComicFigure = ComicIdList.SingleOrDefault(c => c.ComicId == f.ComicId).ComicFigure,
                BgColor = ComicIdList.SingleOrDefault(c => c.ComicId == f.ComicId).BgColor,
                ComicWeekFigure = ComicIdList.SingleOrDefault(c => c.ComicId == f.ComicId).ComicWeekFigure,
            }).ToList();
            result.AddRange(FavoritList);

            return result;
        }

        public void FavoriteDelete()
        {
            var memberId = _memberService.GetCurrentMemberID();

            var DelFavorite = _repository.GetAll<Favorite>().Where(f => f.MemberId == memberId).FirstOrDefault();
            _repository.Delete(DelFavorite);
            _repository.SaveChange();
        }

        public void RemoveFavoriteRecord(RemoveFavoriteInputDTO input)
        {
            var DelFavorite = _repository.GetAll<Favorite>()
                .Where(f => f.MemberId == input.MemberId
                    && input.ComicIdsToDelete.Contains(f.ComicId)
                )//.ToList()
                ;

            foreach (var f in DelFavorite)
            {
                _repository.Delete(f);
            }
            _repository.SaveChange();

        }

        public void FavoriteDataCreateOrDelete(FavoriteDataDTO favoriteData)
        {
            var memberId = _memberService.GetCurrentMemberID();

            var sameData = _repository.GetAll<Favorite>()
                .Where(f => f.MemberId == memberId && f.ComicId == favoriteData.ComicId).FirstOrDefault();

            if (favoriteData.IsLike == true && sameData == null)
            {
                var favorite = new Favorite
                {
                    ComicId = favoriteData.ComicId,
                    MemberId = memberId,
                };
                _repository.Create(favorite);
            }
            else if (favoriteData.IsLike == false && sameData != null)
            {
                _repository.Delete(sameData);
            }
            _repository.SaveChange();
        }
    }
}
