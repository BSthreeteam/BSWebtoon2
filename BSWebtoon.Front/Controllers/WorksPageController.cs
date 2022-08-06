using BSWebtoon.Front.Models.ViewModel.WorkPage;
using BSWebtoon.Front.Service.ComicService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BSWebtoon.Front.Controllers
{
    public class WorksPageController : Controller
    {
        private readonly IComicService _comicService;

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
            var memberId = User.Claims.FirstOrDefault() == null ? 0 : int.Parse(User.Claims.FirstOrDefault(x => x.Type == "MemberID").Value);

            var workPageComic = _comicService.WorkPageRead(Id, memberId);

            var result = new WorkPageViewModel
            {
                IsAuthenticated = User.Identity.IsAuthenticated,
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
                ClickCount = workPageComic.ClickCount,
                ComicLikeCount = workPageComic.ComicLikeCount,
                ViewRecordEpTitle = workPageComic.ViewRecordEpTitle,

                Publisher = workPageComic.Publisher,
                Painter = workPageComic.Painter,
                Author = workPageComic.Author,

                ComicStatus = workPageComic.ComicStatus,
                UpdateWeek = workPageComic.UpdateWeek,
                Introduction = workPageComic.Introduction,

                EpList = workPageComic.EpList.Select(ep => new WorkPageViewModel.EpData
                {
                    EpId = ep.EpId,
                    ComicId = ep.ComicId,
                    EpTitle = ep.EpTitle,
                    EpCover = ep.EpCover,
                    UploadTime = ep.UploadTime,
                    IsCountdownCoupon = ep.IsCountdownCoupon,
                    IsFree = ep.IsFree
                }).ToList(),

                CommentList = workPageComic.CommentList.Select(c => new WorkPageViewModel.CommentData
                {
                    CommentId = c.CommentId,
                    CommentMemberName = c.CommentMemberName,
                    EpId = c.EpId,
                    ReplyToCommentCount = c.ReplyToCommentCount,
                    IsSpoiler = c.IsSpoiler,
                    CreateTime = c.CreateTime,
                    Context = c.Context,
                    IsDelete = c.IsDelete,
                    CommentLikeCount = c.CommentLikeCount,
                    CommentReportCount = c.CommentReportCount
                }).ToList()
            };
            return View(result);
        }



        public IActionResult workContent(int Id)
        {

            var memberId = User.Claims.FirstOrDefault() == null ? 0 : int.Parse(User.Claims.FirstOrDefault(x => x.Type == "MemberID").Value);

            var outputDto = _comicService.ReadworkContent(Id, memberId);


            var epContents = outputDto.WorkContents;

            var result = new WorkContentViewModel();


            if (epContents == null)
            {
                return RedirectToAction("BuyCoupon", "WorksPage", new { id = outputDto.ComicId });
            }

            var epTable = outputDto.EpList;

            result = new WorkContentViewModel()
            {
                EpId = epContents.Select(e => e.EpId).First(),
                EpTitle = epContents.Select(e => e.EpTitle).First(),

                ContentList = epContents.Select(e => new WorkContentViewModel.Content
                {
                    ImagePath = e.ImagePath,
                    Page = e.Page,
                }).ToList(),
                EpList = epTable.Select(e => new WorkContentViewModel.EpData
                {
                    EpId = e.EpId,
                    ComicId = e.ComicId,
                    EpTitle = e.EpTitle,
                    EpCover = e.EpCover,
                    UploadTime = e.UploadTime,
                    IsCountdownCoupon = e.IsCountdownCoupon,
                    IsFree = e.IsFree

                }).ToList() 
            };


            return View(result);
        }

    }


}

