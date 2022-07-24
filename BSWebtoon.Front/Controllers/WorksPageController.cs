using BSWebtoon.Front.Models.ViewModel.WorkPage;
using BSWebtoon.Front.Service.ComicService;
using BSWebtoon.Front.Service.ContentPageService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using static BSWebtoon.Front.Models.ViewModel.WorkPage.WorkPageViewModel;

namespace BSWebtoon.Front.Controllers
{
    public class WorksPageController : Controller
    {
        private readonly IComicService _comicService;
        private readonly IComicContentPageService _comicContentPageService;

        public WorksPageController(IComicService comicService)
        {
            _comicService = comicService;
        }
        public IActionResult BuyCoupon()
        {
            return View();
        }
        [HttpGet]
        public IActionResult WorksPage(int Id) //WorksPage/WorksPage/1
        {
            string name = User.Identity.Name;
            var workPageComic = _comicService.WorkPageRead(Id,name);

            var result = new WorkPageViewModel
            {
                MemberId = workPageComic.MemberId,
                ComicId = workPageComic.ComicId,
                ComicChineseName = workPageComic.ComicChineseName,
                BgCover = workPageComic.BgCover,
                ComicFigure = workPageComic.ComicFigure,
                BgColor = workPageComic.BgColor,
                BannerVideoWeb = workPageComic.BannerVideoWeb,
                ComicVideoWeb = workPageComic.ComicVideoWeb,
                ReadTicket = workPageComic.ReadTicket,
                IslikeComic = workPageComic.IslikeComic,
                MainTagName = workPageComic.MainTagName,
                TagNames = workPageComic.TagNames,
                ViewCount = workPageComic.ViewCount,
                ComicLikeCount = workPageComic.ComicLikeCount,
                ViewRecordEpTitle = workPageComic.ViewRecordEpTitle,

                Publisher = workPageComic.Publisher,
                Painter = workPageComic.Painter,
                Author = workPageComic.Author,

                ComicStatus = workPageComic.ComicStatus,
                UpdateWeek = workPageComic.UpdateWeek,
                Introduction = workPageComic.Introduction,

                EpList = workPageComic.EpList.Select(ep => new EpData
                {
                    EpId = ep.EpId,
                    ComicId = ep.ComicId,
                    EpTitle = ep.EpTitle,
                    EpCover = ep.EpCover,
                    UploadTime = ep.UploadTime,
                    IsCountdownCoupon = ep.IsCountdownCoupon,
                    IsFree = ep.IsFree
                }),

                CommentList = workPageComic.CommentList.Select(c => new CommentData
                {
                    CommentId = c.CommentId,
                    CommentMemberName = c.CommentMemberName,
                    EpId = c.EpId,
                    ReplyToCommentId = c.ReplyToCommentId,
                    IsSpoiler = c.IsSpoiler,
                    CreateTime = c.CreateTime,
                    Context = c.Context,
                    IsDelete = c.IsDelete,
                    CommentLikeCount = c.CommentLikeCount
                })
            };
            //return View(workPageComic);
            return View(result);
        }
    }
}
