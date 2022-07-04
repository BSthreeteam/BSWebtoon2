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

        //Task<List<ClickCountViewModel>> ClickCount();

        //IEnumerable<ActivityViewModel> ActivityRead();
    }
}
