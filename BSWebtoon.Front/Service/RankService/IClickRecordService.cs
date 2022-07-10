using BSWebtoon.Front.Models.DTO.Rank;
using System.Collections.Generic;

namespace BSWebtoon.Front.Service.RankService
{
    public interface IClickRecordService
    {
        void ClickRecordCreate();
        void UpdateRank();

        List<AllTagRankDTO> ReadAllRank();
    }
}
