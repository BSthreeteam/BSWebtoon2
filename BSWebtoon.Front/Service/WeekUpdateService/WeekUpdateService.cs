using BSWebtoon.Front.ViewModel;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System.Collections.Generic;

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

    }
}
