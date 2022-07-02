using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System;
using System.Collections.Generic;

namespace BSWebtoon.Front.Service.RankService
{
    public class ClickRecordService:IClickRecordService
    {
        private readonly BSWeBtoonContext _context;
        private readonly BSRepository _repository;
        public ClickRecordService(BSWeBtoonContext context, BSRepository repository)
        {
            _context = context;
            _repository = repository;
        }
        public void ClickRecordCreate()
        {
            var clickRecod = new List<ClickRecord> {
                new ClickRecord {ClickRecordId=1,ComicId=1,CreateTime=new DateTime(2021,07,21),MemberId=1},
                new ClickRecord {ClickRecordId=1,ComicId=2,CreateTime=new DateTime(2021,07,23),MemberId=2}
            };
            //var data = new Activity() { ActivityName = "BuildSchoolDEMO", ActivityStartTime = new DateTime(2022, 08, 01), ActivityEndTime = new DateTime(2022, 08, 15), ActivityImage = "jpg", ActivityBgColor = "#CF9B68", ActivityContent = "<h2>DEMO Day</h2><br><p>祝大家有個美好的未來!</p>", PrincipalEmployee = 2, CreateTime = new DateTime(2022, 08, 01), IsDelete = false };
            foreach (ClickRecord click in clickRecod)
            {
                _repository.Create(click);

            }

            //_repository.Delete(data);
            _repository.SaveChange();
        }
    }
}
