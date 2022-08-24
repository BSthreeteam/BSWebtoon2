using BSWebtoon.Front.Models.ViewModel.WeekUpdate;
using BSWebtoon.Front.Service.WeekUpdateService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using BSWebtoon.Model.Repository.Interface;
using BSWebtoon.Front.Models.DTO.WeekUpDate;

namespace BSWebtoon.Front.Controllers
{
    public class WeekUpdateController : Controller
    {
        private readonly IWeekUpdateService _weekUpdateService;
        private readonly IMemoryCacheRepository _iMemoryCacheRepository;

        public WeekUpdateController(IWeekUpdateService weekUpdateService, IMemoryCacheRepository iMemoryCacheRepository)
        {
            _weekUpdateService = weekUpdateService;
            _iMemoryCacheRepository = iMemoryCacheRepository;
        }

        public IActionResult WeekUpdate()
        {
            const string redisKey = "Week.GetWeekComic";
            var weekUpdates = _iMemoryCacheRepository.Get<List<WeekUpDateDTO>>(redisKey);

            //var weekUpdates = _weekUpdateService.ReadWeekComic();
            var result = new List<WeekUpdateViewModel>();
            foreach (var weekUpdate in weekUpdates)
            {

                var weekComicSoruse = new WeekUpdateViewModel
                {
                    WeekDay = weekUpdate.WeekDay,
                    WeekComicLongList = weekUpdate.WeekUpDateList.Where(c => c.WeekVideoWrb != string.Empty).Select(c => new WeekUpdateViewModel.WeekUpdateDataLing
                    {
                        ComicId = c.ComicId,
                        BgCover = c.BgCover,
                        ComicNameImage = c.ComicNameImage,
                        ComicStatus = c.ComicStatus,
                        UpdateWeek = c.UpdateWeek,
                        WeekVideoWrb = c.WeekVideoWrb

                    }).ToList(),
                    WeekComicList = weekUpdate.WeekUpDateList.Where(c => c.WeekVideoWrb == string.Empty).Select(c => new WeekUpdateViewModel.WeekUpdateData
                    {
                        ComicId = c.ComicId,
                        BgCover = c.BgCover,
                        ComicNameImage = c.ComicNameImage,
                        ComicStatus = c.ComicStatus,
                        ComicWeekFigure = c.ComicWeekFigure,
                        UpdateWeek = c.UpdateWeek
                    }).ToList()

                };
                result.Add(weekComicSoruse);
            }

            return View(result);

        }
        public IActionResult NewComic()
        {
            const string redisKey = "Week.GetNewComic";
            var newComics = _iMemoryCacheRepository.Get<List<NewComicDTO>>(redisKey);

            //var newComics = _weekUpdateService.ReadNewComic();

            var result = new List<NewComicViewModel>();

            result = newComics.Select(c => new NewComicViewModel
            {
                Author = c.Author,
                PublishDate = c.PublishDate.ToString("MM.dd"),
                BgCover = c.BgCover,
                ComicFigure = c.ComicFigure,
                ComicId = c.ComicId,
                ComicNameImage = c.ComicNameImage,
                Introduction = c.Introduction,
                Painter = c.Painter
            }).ToList();

            return View(result);



        }
        public IActionResult FinishComic()
        {
            const string redisKey = "Week.GetFinishComic";
            var finishComics = _iMemoryCacheRepository.Get<List<FinishComicDTO>>(redisKey);

            //var finishComics = _weekUpdateService.ReadFinishComic();
            var finishComicBig = finishComics.First();

            var result = new FinishComicViewModel();

            result = new FinishComicViewModel()
            {
                FinishComicBig = new FinishComicViewModel.FinishComicBigData
                {
                    Author = finishComicBig.Author,
                    BgCover = finishComicBig.BgCover,
                    ComicFigure = finishComicBig.ComicFigure,
                    ComicId = finishComicBig.ComicId,
                    ComicNameImage = finishComicBig.ComicNameImage,
                    Introduction = finishComicBig.Introduction.Substring(0, 30),
                    Painter = finishComicBig.Painter

                },

                FinishComicList = finishComics.Skip(1).Select(c => new FinishComicViewModel.FinishComicData
                {
                    BgCover = c.BgCover,
                    ComicWeekFigure = c.ComicWeekFigure,
                    ComicId = c.ComicId,
                    ComicNameImage = c.ComicNameImage
                }).ToList()
            };


            return View(result);
        }
    }
}    
