using BSWebtoon.Front.Models.DTO.WeekUpDate;
using System.Collections.Generic;

namespace BSWebtoon.Front.Service.WeekUpdateService
{
    public interface IWeekUpdateService
    {
        public List<WeekUpDateDTO> ReadWeekComic();

        public List<NewComicDTO> ReadNewComic();
        public List<FinishComicDTO> ReadFinishComic();
    }
}
