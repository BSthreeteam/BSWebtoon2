using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BSWebtoon.Front.Service.RecommendService
{
    public class RecommendService: IRecommendService
    {
        private readonly BSWeBtoonContext _context;
        private readonly BSRepository _repository;
        public RecommendService(BSWeBtoonContext context, BSRepository repository)
        {
            _context = context;
            _repository = repository;
            //ActivityCreate();
        }
        public void ActivityCreate()
        {
            //var activityList = new List<Activity> {
            //    new Activity {ActivityId = 1, ActivityName = "端午佳節",ActivityStartTime=new DateTime(2022,05,27),ActivityEndTime=new DateTime(2022,06,10),ActivityImage="jpg",ActivityBgColor="#517664",ActivityContent="<h2>禮輕情意粽</h2><br><p>端午節放假!<br>看本漫畫放鬆自己吧!</p>",PrincipalEmployee=1,CreateTime=new DateTime(2022,05,01),IsDelete = false},
            //    new Activity {ActivityId = 2, ActivityName = "BuildSchoolDEMO",ActivityStartTime=new DateTime(2022,08,01),ActivityEndTime=new DateTime(2022,08,15),ActivityImage="jpg",ActivityBgColor="#CF9B68",ActivityContent="<h2>DEMO Day</h2><br><p>祝大家有個美好的未來!</p>",PrincipalEmployee=2,CreateTime=new DateTime(2022,08,01),IsDelete = false},
            //    new Activity {ActivityId = 3, ActivityName = "中秋賞月",ActivityStartTime=new DateTime(2022,09,03),ActivityEndTime=new DateTime(2022,09,17),ActivityImage="jpg",ActivityBgColor="#CF9B68",ActivityContent="<h2>中秋月圓圓</h2><br><p>中秋節放假!<br>看本漫畫放鬆自己吧!</p>",PrincipalEmployee=1,CreateTime=new DateTime(2022,09,01),IsDelete = false},
            //};
            var data = new Activity { ActivityId = 1, ActivityName = "端午佳節", ActivityStartTime = new DateTime(2022, 05, 27), ActivityEndTime = new DateTime(2022, 06, 10), ActivityImage = "jpg", ActivityBgColor = "#517664", ActivityContent = "<h2>禮輕情意粽</h2><br><p>端午節放假!<br>看本漫畫放鬆自己吧!</p>", PrincipalEmployee = 1, CreateTime = new DateTime(2022, 05, 01), IsDelete = false , PrincipalEmployeeNavigation = new Employee {EmployeeId=1}, };
            _repository.Create(data);
            _repository.SaveChange();
        }
    }
}
