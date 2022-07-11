using BSWebtoon.Front.Models.DTO.WeekUpData;
using BSWebtoon.Front.Models.DTO.WeekUpDate;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BSWebtoon.Front.Service.WeekUpdateService
{
    public class WeekUpdateService : IWeekUpdateService
    {
        private readonly BSRepository _repository;

        public WeekUpdateService(BSRepository repository, BSWebtoonContext context)
        {
            _repository = repository;
        }

        public List<WeekUpDateDTO> ReadWeekComic()
        {
            //var comicorderby = WeekUpDate.GroupBy(c => c.ComicId).ToDictionary(c => c.Key, c => c.Count()).OrderByDescending(c => c.Value)/*.Select(c => c.Key)*/;
            var comicList = _repository.GetAll<Comic>().Where(c => c.ComicStatus != 1 && c.AuditType == 1).OrderBy(c => c.ComicId);//撇除完結類
            //var comicorderby = comicClickRecords.OrderByDescending(c => c.Value).Select(c => c.Key);
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
            var newComicSource = _repository.GetAll<Comic>().Where(c => c.ComicStatus == 4 && c.AuditType==1).OrderByDescending(c => c.PublishDate);

            var result = new List<NewComicDTO>();

            result = newComicSource.Select(c => new NewComicDTO
            {
                ComicId = c.ComicId,
                ComicNameImage = c.ComicFigure,
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
            var finishComicSource = _repository.GetAll<Comic>().Where(c => c.ComicStatus == 1 && c.AuditType==1);
            var clickRecordGroup = _repository.GetAll<ClickRecord>().GroupBy(c => c.ComicId);

            var finishComicList = new List<FinishComicDTO>();

            foreach (var finishComic in finishComicSource)
            {
                var ComicClickList = clickRecordGroup.Where(c => c.Key == finishComic.ComicId);
                var ComicClickCount = ComicClickList.Any() ? ComicClickList.Select(x => x.Count()).First() : 0;

                finishComicList.Add(new FinishComicDTO
                {
                    ComicId = finishComic.ComicId,
                    ComicNameImage = finishComic.ComicFigure,
                    BgCover = finishComic.BgCover,
                    ComicFigure = finishComic.ComicFigure,
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
