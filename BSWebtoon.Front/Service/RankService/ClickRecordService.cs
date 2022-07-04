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
                new ClickRecord {ClickRecordId=1,ComicId=1,CreateTime=new DateTime(2021,07,21),MemberId=1},
                new ClickRecord {ClickRecordId=2,ComicId=2,CreateTime=new DateTime(2021,07,23),MemberId=2}
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
