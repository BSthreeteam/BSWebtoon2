using BSWebtoon.Model.ViewModels;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSWebtoon.Front.Service.RecommendService
{
    public class RecommendService : IRecommendService
    {
        private readonly BSWebtoonContext _context;
        private readonly BSRepository _repository;
        public RecommendService(BSWebtoonContext context, BSRepository repository)
        {
            _context = context;
            _repository = repository;
            //ActivityCreate();
        }
        public void ActivityCreate()
        {
            var activityList = new List<Activity> {
                new Activity { ActivityName = "端午佳節",ActivityStartTime=new DateTime(2022,05,27),ActivityEndTime=new DateTime(2022,06,10),ActivityImage="jpg",ActivityBgColor="#517664",ActivityContent="<h2>禮輕情意粽</h2><br><p>端午節放假!<br>看本漫畫放鬆自己吧!</p>",PrincipalEmployee=1,CreateTime=new DateTime(2022,05,01),IsDelete = false},
                new Activity { ActivityName = "BuildSchoolDEMO",ActivityStartTime=new DateTime(2022,08,01),ActivityEndTime=new DateTime(2022,08,15),ActivityImage="jpg",ActivityBgColor="#CF9B68",ActivityContent="<h2>DEMO Day</h2><br><p>祝大家有個美好的未來!</p>",PrincipalEmployee=2,CreateTime=new DateTime(2022,08,01),IsDelete = false},
                new Activity { ActivityName = "中秋賞月",ActivityStartTime=new DateTime(2022,09,03),ActivityEndTime=new DateTime(2022,09,17),ActivityImage="jpg",ActivityBgColor="#CF9B68",ActivityContent="<h2>中秋月圓圓</h2><br><p>中秋節放假!<br>看本漫畫放鬆自己吧!</p>",PrincipalEmployee=1,CreateTime=new DateTime(2022,09,01),IsDelete = false},
            };
            //var data = new Activity() { ActivityName = "BuildSchoolDEMO", ActivityStartTime = new DateTime(2022, 08, 01), ActivityEndTime = new DateTime(2022, 08, 15), ActivityImage = "jpg", ActivityBgColor = "#CF9B68", ActivityContent = "<h2>DEMO Day</h2><br><p>祝大家有個美好的未來!</p>", PrincipalEmployee = 2, CreateTime = new DateTime(2022, 08, 01), IsDelete = false };
            foreach (Activity activity in activityList)
            {
                _repository.Create(activity);

            }

            //_repository.Delete(data);
            _repository.SaveChange();
        }
        public void ViewRecordCreate()
        {
            var viewRecordList = new List<ViewRecord>()
            {
                new ViewRecord(){ MemberId=1,EpContentId=4,ViewTime=new DateTime(2022,06,01)},
                new ViewRecord(){ MemberId=2,EpContentId=8,ViewTime=new DateTime(2022,06,04)},
            };
            foreach (ViewRecord record in viewRecordList)
            {
                _repository.Create(record);
            }
            _repository.SaveChange();
        }

        public void CommentCreate()
        {
            var commentList = new List<Comment>()
            {
                new Comment(){MemberId=1,EpId=2,ReplyToCommentId=null,IsSpoiler=false,CreateTime=new DateTime(2022,06,01,13,45,00),Context="超好看!!!老師太厲害了!",IsDelete=false},
                new Comment(){MemberId=2,EpId=4,ReplyToCommentId=null,IsSpoiler=true,CreateTime=new DateTime(2022,06,04,18,30,00),Context="女主角超心機  不過我喜歡<br>哈哈哈",IsDelete=false},
            };
            foreach (Comment comment in commentList)
            {
                _repository.Create(comment);
            }
            _repository.SaveChange();
        }

        public void LikeCreate()
        {
            var likeList = new List<CommentLikeRecord>
            {
                new CommentLikeRecord(){ MemberId=1, CommentId=1, CreateTime=new DateTime(2022,06,01,13,47,00), IsLike = true},
                new CommentLikeRecord(){ MemberId=2, CommentId=2, CreateTime=new DateTime(2022,06,04,18,35,00), IsLike = true},
            };
            foreach (CommentLikeRecord Like in likeList)
            {
                _repository.Create(Like);
            }
            _repository.SaveChange();
        }

        public void ReportCreate()
        {
            var reportList = new List<Report>
            {
                new Report(){ CommentId=2,CreateTime=new DateTime(2022,06,05,12,20,00),AuditType=4,AuditEmployeeId=1,AuditTime=new DateTime(2022,06,05,16,00,00),Reason="我看他不爽!!!"}
            };
            foreach (Report report in reportList)
            {
                _repository.Create(report);
            }
            _repository.SaveChange();
        }

        public async Task<List<ClickCountViewModel>> ClickCount()
        {
            var query = (await _context.ClickRecord.ToListAsync()).GroupBy(comic => comic.ComicId).Select(g => new ClickCountViewModel { ComicId = g.Key, Count = g.Count() });
        
            return query.ToList();
        }
    }
}
