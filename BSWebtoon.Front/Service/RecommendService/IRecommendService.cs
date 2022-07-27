using BSWebtoon.Front.Models.DTO.Recommend;
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

        RecommendDTO ReadRecommend();
        HitWorkDTO ReadHitWork();
    }
}
