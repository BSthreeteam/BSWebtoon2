using System.Collections.Generic;
using BSWebtoon.Model.ViewModel;

namespace BSWebtoon.Front.Service.RecommendService
{
    public interface IRecommendService
    {
        void ActivityCreate();
        void ViewRecordCreate();
        void CommentCreate();
        void LikeCreate();
        void ReportCreate();

        IEnumerable<ActivityViewModel> ActivityRead();
    }
}
