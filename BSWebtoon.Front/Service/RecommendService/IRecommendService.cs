using BSWebtoon.Front.Models.DTO.Recommend;
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
        void CommentLikeCreate();
        void ReportCreate();

        IEnumerable<RecommendDTO> ReadRecommend();
        IEnumerable<HitWorkViewModel> ReadHitWork();
        //IEnumerable<ActivityViewModel> ActivityRead();
    }
}
