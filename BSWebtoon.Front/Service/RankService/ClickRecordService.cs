using BSWebtoon.Front.ViewModel;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BSWebtoon.Front.Service.RankService
{
    public class ClickRecordService : IClickRecordService
    {
        private readonly BSWebtoonContext _context;
        private readonly BSRepository _repository;
        private static string _connectionStr = "Server=(localdb)\\mssqllocaldb;Database=BS;Trusted_Connection=True;";
        public ClickRecordService(BSWebtoonContext context, BSRepository repository)
        {
            _context = context;
            _repository = repository;
        }
        public void ClickRecordCreate()
        {
            var clickRecod = new List<ClickRecord> {
                new ClickRecord {ClickRecordId=1,ComicId=1,CreateTime=new DateTime(2022,07,21),MemberId=1},
                new ClickRecord {ClickRecordId=2,ComicId=1,CreateTime=new DateTime(2022,07,23),MemberId=3},
                new ClickRecord {ClickRecordId=3,ComicId=3,CreateTime=new DateTime(2022,07,18),MemberId=2},
                new ClickRecord {ClickRecordId=4,ComicId=15,CreateTime=new DateTime(2022,07,18),MemberId=15},
                new ClickRecord {ClickRecordId=5,ComicId=1,CreateTime=new DateTime(2022,07,19),MemberId=17},
                new ClickRecord {ClickRecordId=6,ComicId=5,CreateTime=new DateTime(2022,07,20),MemberId=4},
                new ClickRecord {ClickRecordId=7,ComicId=7,CreateTime=new DateTime(2022,07,17),MemberId=7},
                new ClickRecord {ClickRecordId=8,ComicId=14,CreateTime=new DateTime(2022,07,15),MemberId=18},
                new ClickRecord {ClickRecordId=9,ComicId=2,CreateTime=new DateTime(2022,07,25),MemberId=16},
                new ClickRecord {ClickRecordId=10,ComicId=3,CreateTime=new DateTime(2022,07,27),MemberId=19},
                new ClickRecord {ClickRecordId=11,ComicId=4,CreateTime=new DateTime(2022,07,29),MemberId=10},
                new ClickRecord {ClickRecordId=12,ComicId=17,CreateTime=new DateTime(2022,07,24),MemberId=16},
                new ClickRecord {ClickRecordId=13,ComicId=8,CreateTime=new DateTime(2022,07,22),MemberId=12},
                new ClickRecord {ClickRecordId=14,ComicId=10,CreateTime=new DateTime(2022,07,23),MemberId=5},
                new ClickRecord {ClickRecordId=15,ComicId=16,CreateTime=new DateTime(2022,07,31),MemberId=7},
                new ClickRecord {ClickRecordId=16,ComicId=17,CreateTime=new DateTime(2022,07,26),MemberId=16},
                new ClickRecord {ClickRecordId=17,ComicId=18,CreateTime=new DateTime(2022,07,29),MemberId=12},
                new ClickRecord {ClickRecordId=18,ComicId=6,CreateTime=new DateTime(2022,07,30),MemberId=2},
                new ClickRecord {ClickRecordId=19,ComicId=1,CreateTime=new DateTime(2022,07,21),MemberId=8},
                new ClickRecord {ClickRecordId=20,ComicId=2,CreateTime=new DateTime(2022,07,23),MemberId=9},
            };
            //var data = new Activity() { ActivityName = "BuildSchoolDEMO", ActivityStartTime = new DateTime(2022, 08, 01), ActivityEndTime = new DateTime(2022, 08, 15), ActivityImage = "jpg", ActivityBgColor = "#CF9B68", ActivityContent = "<h2>DEMO Day</h2><br><p>祝大家有個美好的未來!</p>", PrincipalEmployee = 2, CreateTime = new DateTime(2022, 08, 01), IsDelete = false };
            foreach (ClickRecord click in clickRecod)
            {
                _repository.Create(click);

            }

            //_repository.Delete(data);
            _repository.SaveChange();
        }


        public IEnumerable<RankViewModel> ReadRank()
        {
            //var clickcount = _repository.GetAll<ClickRecord>().GroupBy(c => c.ComicId).Select(c => c.Count(gp=>gp.ComicId==c.Key));
            //foreach(var index in clickcount)
            //{
            //    return index;
            //}

            return from clickrecord in _repository.GetAll<ClickRecord>()
                   join comic in _repository.GetAll<Comic>()
                   on clickrecord.ComicId equals comic.ComicId
                   join comicTagList in _repository.GetAll<ComicTagList>()
                   on comic.ComicId equals comicTagList.ComicId
                   join comicTag in _repository.GetAll<ComicTag>()
                   on comicTagList.TagId equals comicTag.TagId
                   where comicTag.IsMainTag == true
                   select new RankViewModel
                   {
                       ComicId = comic.ComicId,
                       ComicName = comic.ComicChineseName,
                       ComicNameImage = comic.ComicNameImage,
                       Introduction = comic.Introduction.Substring(0, 50),
                       ComicFigure = comic.ComicFigure,
                       BgCover = comic.BgCover,
                       BgColor = comic.BgColor,
                       TagName = comicTag.TagName,
                       //ClickCount = clickcount;
                   };
        }


        public void UpdateRank()
        {
            var updatarank = _repository.GetAll<ClickRecord>().Where(x => x.ClickRecordId == 2).FirstOrDefault();
            updatarank.CreateTime = new DateTime(2021, 07, 24);
            _repository.Update(updatarank);
            _repository.SaveChange();
        }
    }
}
