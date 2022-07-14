namespace BSWebtoon.Front.Service.RecommendService
{
    public interface IRecommendService
    {
        void ActivityCreate();
        void ViewRecordCreate();
        void CommentCreate();
        void CommentLikeCreate();
        void ReportCreate();

        //Task<List<ClickCountViewModel>> ClickCount();

        //IEnumerable<ActivityViewModel> ActivityRead();
    }
}
