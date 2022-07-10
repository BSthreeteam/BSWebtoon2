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
        //private readonly BSWeBtoonContext _context;

        public WeekUpdateService(BSRepository repository, BSWebtoonContext context)
        {
            _repository = repository;
            //_context = context;
        }

        public List<WeekUpDateDTO> ReadComic()
        {
            return new List<WeekUpDateDTO>()
            {
                new WeekUpDateDTO(){}
            };
        }

    }
}
