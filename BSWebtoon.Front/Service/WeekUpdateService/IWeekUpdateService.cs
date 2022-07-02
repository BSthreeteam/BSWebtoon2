using BSWebtoon.Front.ViewModel;
using System.Collections.Generic;

namespace BSWebtoon.Front.Service.WeekUpdateService
{
    public interface IWeekUpdateService
    {
        public IEnumerable<WeekUpdateViewModel> ReadComic();
    }
}
