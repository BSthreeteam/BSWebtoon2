using BSWebtoon.Front.Models.DTO.WeekUpData;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
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

        public IEnumerable<WeekUpDateDTO> ReadComic()
        {
            var comicsource = _repository.GetAll<Comic>().Where(c=>c.ComicStatus != 1).OrderBy(c => c.ComicId);
            //var comicorderby = _repository.GetAll<Comic>().Where(co=>co.UpdateWeek = comicsource)

            //var comicClickRecords = _repository.GetAll<ClickRecord>().GroupBy(c => c.ComicId).ToDictionary(c => c.Key,c=>c.Count());

            return comicsource.Select(c => new WeekUpDateDTO
            {
                ComicId = c.ComicId,
                ComicNameImage = c.ComicNameImage,
                ComicStatus = c.ComicStatus,
                UpdateWeek = c.UpdateWeek,
                BgCover = c.BgCover,
                ComicWeekFigure = c.ComicWeekFigure,
                WeekVideoWrb = c.WeekVideoWrb,
            });

        }
    }
}
