using BSWebtoon.Front.Models.DTO.Rcommend;
using BSWebtoon.Front.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BSWebtoon.Front.Service.RecommendService
{
    public interface IRecommendService
    {
        void ActivityCreate();
        void ViewRecordCreate();
        void CommentCreate();
        void LikeCreate();
        void ReportCreate();

        IEnumerable<RecommendDTO> ReadRecommend();
        IEnumerable<HitWorkDTO> ReadHitWork();
        //IEnumerable<ActivityViewModel> ActivityRead();
    }
}
