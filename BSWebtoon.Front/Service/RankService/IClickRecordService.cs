using BSWebtoon.Front.ViewModel;
using System.Collections.Generic;

namespace BSWebtoon.Front.Service.RankService
{
    public interface IClickRecordService
    {
        void ClickRecordCreate();
        void UpdateRank();

        //string ReadRank();
        //IEnumerable<RankViewModel> ReadRank();
        //void ReadRank();
    }
}
