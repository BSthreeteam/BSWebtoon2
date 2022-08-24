using BSWebtoon.Front.Models.DTO.WeekUpDate;
using BSWebtoon.Model;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BSWebtoon.Front.Service.WeekUpdateService
{
    public class WeekUpdateService : IWeekUpdateService
    {
        private readonly BSRepository _repository;

        public WeekUpdateService(BSRepository repository)
        {
            _repository = repository;
        }

        public List<WeekUpDateDTO> ReadWeekComic()
        {

            //var comicorderby = WeekUpDate.GroupBy(c => c.ComicId).ToDictionary(c => c.Key, c => c.Count()).OrderByDescending(c => c.Value)/*.Select(c => c.Key)*/;
            //var comicorderby = comicClickRRechargeRecordViewecords.OrderByDescending(c => c.Value).Select(c => c.Key);
            var comicSource = _repository.GetAll<Comic>().Where(c => c.AuditType == (int)AuditType.auditPass);//撇除未審核
            var newComicSource = comicSource.Where(c => c.ComicStatus == (int)ComicState.newWork && c.PublishDate <= DateTime.UtcNow.AddHours(8)).Select(c=>c.ComicId);//找出已上架的新作漫畫
            var comicList = comicSource.Where(c => c.ComicStatus == (int)ComicState.serialize || c.ComicStatus == (int)ComicState.stopUpdate || c.ComicId == newComicSource.FirstOrDefault()).OrderBy(c => c.ComicId);//連載、停更、已上架的新作漫畫類
            var clickRecordGroup = _repository.GetAll<ClickRecord>().GroupBy(x => x.ComicId);

            var result = new List<WeekUpDateDTO>();
            var weekDateList = new List<WeekDayComic>();
            foreach (var comic in comicList)
            {
                var ComicClickList = clickRecordGroup.Where(x => x.Key == comic.ComicId);
                var ComicClickCount = ComicClickList.Any() ? ComicClickList.Select(x => x.Count()).First() : 0;

                weekDateList.Add(new WeekDayComic
                {
                    ComicId = comic.ComicId,
                    ComicNameImage = comic.ComicNameImage,
                    ComicStatus = comic.ComicStatus,
                    UpdateWeek = comic.UpdateWeek,
                    BgCover = comic.BgCover,
                    ComicWeekFigure = comic.ComicWeekFigure,
                    WeekVideoWrb = comic.WeekVideoWrb,
                    ViewCount = ComicClickCount
                });

            }
            result = weekDateList.GroupBy(x => x.UpdateWeek).Select(x => new WeekUpDateDTO
            {
                WeekDay = (int)x.Key,
                WeekUpDateList = x.OrderBy(data => data.ViewCount).ToList()
            }).ToList();

            return result;
        }
        public List<NewComicDTO> ReadNewComic()
        {
            var newComicSource = _repository.GetAll<Comic>().Where(c => c.ComicStatus == (int)ComicState.newWork && c.AuditType == (int)AuditType.auditPass).OrderByDescending(c => c.PublishDate);

            var result = new List<NewComicDTO>();


            result = newComicSource.Select(c => new NewComicDTO
            {
                ComicId = c.ComicId,
                ComicNameImage = c.ComicNameImage,
                BgCover = c.BgCover,
                ComicFigure = c.ComicFigure,
                Author = c.Author,
                Painter = c.Painter,
                Introduction = c.Introduction,
                PublishDate = c.PublishDate

            }).ToList();
            return result;
        }
        public List<FinishComicDTO> ReadFinishComic()
        {

            var finishComicSource = _repository.GetAll<Comic>().Where(c => c.ComicStatus == (int)ComicState.finish && c.AuditType == (int)AuditType.auditPass);
            var clickRecordGroup = _repository.GetAll<ClickRecord>().GroupBy(c => c.ComicId);

            var finishComicList = new List<FinishComicDTO>();

            foreach (var finishComic in finishComicSource)
            {
                var ComicClickList = clickRecordGroup.Where(c => c.Key == finishComic.ComicId);
                var ComicClickCount = ComicClickList.Any() ? ComicClickList.Select(x => x.Count()).First() : 0;

                finishComicList.Add(new FinishComicDTO
                {
                    ComicId = finishComic.ComicId,
                    ComicNameImage = finishComic.ComicNameImage,
                    BgCover = finishComic.BgCover,
                    ComicFigure = finishComic.ComicFigure,
                    ComicWeekFigure = finishComic.ComicWeekFigure,
                    Author = finishComic.Author,
                    Painter = finishComic.Painter,
                    Introduction = finishComic.Introduction,
                    ComicClickCount = ComicClickCount

                });

            }
            var result = finishComicList.OrderByDescending(c => c.ComicClickCount).ToList();

            return result;
        }
    }
}
