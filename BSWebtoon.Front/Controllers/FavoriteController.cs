﻿using BSWebtoon.Front.Models.DTO.FavoriteDTO;
using System.Linq;
using BSWebtoon.Front.Models.ViewModel.ViewRecord;
using BSWebtoon.Front.Models.ViewModel.Favorite;
using BSWebtoon.Front.Service.FavoriteService;
using BSWebtoon.Front.Service.MemberService;
using BSWebtoon.Front.Service.RecordViewService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BSWebtoon.Front.Controllers
{
    public class FavoriteController : Controller
    {
        private readonly IFavoriteService _favoriteService;
        private readonly IRecordViewService _recordView;
        public FavoriteController(IFavoriteService favoriteService, IRecordViewService recordView)
        {
            _favoriteService = favoriteService;
            _recordView = recordView;
        }
        public IActionResult RecordView()//Favorite/RecordView
        {
            var memberId = int.Parse(User.Claims.First(x => x.Type == "MemberID").Value);
            //將UserId丟入Service
            var allviewcomics = _recordView.ReadRecordView(memberId);

            var restult = new ViewRecordViewModel
            {
                ViewRecordListAll = allviewcomics.Select( comic=> new ViewRecordViewModel.ViewRecordData
                {
                    ViewRecorId = comic.ViewRecorId,
                    ComicId = comic.ComicId,
                    BgCover = comic.BgCover,
                    EpTitle = comic.EpTitle,
                    ComicWeekFigure = comic.ComicWeekFigure,
                    ComicNameImage = comic.ComicNameImage
                }).ToList()
            };
            string jsonResult = JsonConvert.SerializeObject(restult);
            ViewData["jsonResult"] = jsonResult;
            return View(restult);
        }




        public IActionResult AddFavoriteView()//Favorite/AddFavoriteView
        {
            //_favoriteService.FavoriteCreate();
            return View();
		}

        public IActionResult RemoveFavoriteView()//Favorite/RemoveFavoriteView
        {
            //找出目前哪個會員登入
            //var userId = int.Parse(User.Identity.Name);
            // 呼叫 Service 存取資料

            var Favorite = _favoriteService.ReadFavorite(3); //userId換3號會員
            var result = new FavoriteViewModel
            {

                FavoriteList = Favorite.Select(f => new FavoriteViewModel.FavoriteData
                {
                    FavoriteId = f.FavoriteId,
                    MemberId = f.MemberId,
                    ComicId = f.ComicId,
                    ComicChineseName = f.ComicChineseName,
                    ComicEnglishName = f.ComicEnglishName,
                    ComicNameImage = f.ComicNameImage,
                    ComicFigure = f.ComicFigure,
                    BgColor = f.BgColor,
                    ComicWeekFigure = f.ComicWeekFigure,
                }).ToList()
            };
            return View(result);
        }


        [HttpGet]
        public IActionResult FavoriteRemove()
        {
            
            return View();
        }

        //[HttpPost]
        //public IActionResult Favorite([FromBody] FavoriteViewModel request)
        //{
        //var claims =
        //User.Claims.Select(claim => new
        //{
        //    claim.Issuer,
        //    claim.OriginalIssuer,
        //    claim.Type,
        //    claim.Value,
        //});
        //var NameIdentifiers = claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value;
        //var memberName = _repository.GetAll<Member>().Where(x => x.NameIdentifier == NameIdentifiers).Select(X => X.AccountName);

        //    return Ok();
        //}

        //public async Task<IActionResult> Delete()
        //{
        //    //var Favorite = await _favoriteService.FavoriteDelete.ReadFavorite(3); //userId換3號會員
        //    var favorite = await _favoriteService.FavoriteDelete.FirstOrDefaultAsync(f => f.Id == 3);
        //    return View(favorite);
        //}

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var favorite = await _favoriteService.FavoriteDelete
        //}

        //public IActionResult RemoveFavoriteView()//Favorite/RemoveFavoriteView
        //{
        //    _favoriteService.FavoriteDelete();
        //    return View();
        //}

        //public IActionResult AddReadFavoriteList()//Favorite/AddReadFavoriteList
        //{

        //    return View(_readfavoriteService.GetFavorite());
        //}
        public IActionResult ReadFavoriteView()
		{
			//找出目前哪個會員登入
			//var userId = int.Parse(User.Identity.Name);
			// 呼叫 Service 存取資料

			var Favorite = _favoriteService.ReadFavorite(3); //userId換3號會員
			var result = new FavoriteViewModel
			{

				FavoriteList = Favorite.Select(f => new FavoriteViewModel.FavoriteData
				{
					FavoriteId = f.FavoriteId,
					MemberId = f.MemberId,
					ComicId = f.ComicId,
					ComicChineseName = f.ComicChineseName,
					ComicEnglishName = f.ComicEnglishName,
					ComicNameImage = f.ComicNameImage,
					ComicFigure = f.ComicFigure,
					BgColor = f.BgColor,
					ComicWeekFigure = f.ComicWeekFigure,
				}).ToList()
			};
			return View(result);
		}
	}
}
