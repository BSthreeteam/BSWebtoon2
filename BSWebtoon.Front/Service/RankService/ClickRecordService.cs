using BSWebtoon.Front.ViewModel;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Microsoft.Data.SqlClient;
using BSWebtoon.Front.Models.DTO.Rank;
using static BSWebtoon.Front.Models.DTO.Rank.RankDTO;

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
                //new ClickRecord {ClickRecordId=1,ComicId=1,CreateTime=new DateTime(2021,5,20),MemberId=1},
                //new ClickRecord {ClickRecordId=2,ComicId=2,CreateTime=new DateTime(2021,7,23),MemberId=2},
                new ClickRecord {ClickRecordId=3,ComicId=3,CreateTime=new DateTime(2021,7,21),MemberId=1},
                new ClickRecord {ClickRecordId=4,ComicId=1,CreateTime=new DateTime(2021,7,24),MemberId=2},

            };
            foreach (ClickRecord click in clickRecod)
            {
                _repository.Create(click);

            }
            _repository.SaveChange();
        }


        public IEnumerable<RankDTO> ReadRank()    
        {

            var oldClickRecords = _repository.GetAll<ClickRecord>().Where(c => c.CreateTime < new DateTime(2022, 7, 5).AddDays(-7) && c.CreateTime >= new DateTime(2022, 7, 5).AddDays(-14));
            
            var oldGroupBy = oldClickRecords.GroupBy(c => c.ComicId).OrderByDescending(c => c.Count(gp => gp.ComicId == c.Key)).ThenBy(c => c.Key).Select(c => c.Key);

            var newClickRecords = _repository.GetAll<ClickRecord>().Where(c => c.CreateTime < new DateTime(2022, 7, 5) && c.CreateTime >= new DateTime(2022, 7, 5).AddDays(-7));
            
            var newGroupBy= newClickRecords.GroupBy(c => c.ComicId).OrderByDescending(c => c.Count(gp => gp.ComicId == c.Key)).ThenBy(c => c.Key).Select(c => c.Key);

            var newrank = _repository.GetAll<Comic>().Where(n => newGroupBy.Any(nc=>nc==n.ComicId)).ToList();//.Select(n => n.ComicId);
            var tagListSource = _repository.GetAll<ComicTagList>().Where(ts=> newrank.Any(nc=>nc.ComicId==ts.ComicId)).ToList();
            var mainTag = _repository.GetAll<ComicTag>().Where(x => tagListSource.Any(y => y.TagId == x.TagId)).First(x => x.IsMainTag);

            List<int> oldSource = new List<int>();
            List<int> newSource = new List<int>();

            oldSource.AddRange(oldGroupBy);
            newSource.AddRange(newGroupBy);

            var result = newrank.Select(comicrank => new RankDTO
            {
                ComicId = comicrank.ComicId,
                ComicName = comicrank.ComicChineseName,
                ComicNameImage = comicrank.ComicNameImage,
                ComicFigure = comicrank.ComicFigure,
                BgCover = comicrank.BgCover,
                Introduction = comicrank.Introduction,
                BannerVideoWeb = comicrank.BannerVideoWeb,
                TagName = mainTag.TagName,
                Diff = oldSource.IndexOf(comicrank.ComicId) == -1 ? 0 : oldSource.IndexOf(comicrank.ComicId)+1 - newSource.IndexOf(comicrank.ComicId)+1
            });
            return result;






            //var diff = NewClickRecords.Select(ncr => oldsource.IndexOf(ncr) - newsource.IndexOf(ncr) == 0? -1 : oldsource.IndexOf(ncr) - newsource.IndexOf(ncr));

            //foreach (var news in newsource)
            //{
            //    var aaa = (oldsource.IndexOf(news) + 1);
            //    var bbb = (newsource.IndexOf(news) + 1);
            //    if (aaa == 0)
            //    {
            //        Console.WriteLine($"{news}:new");
            //    }
            //    else
            //    {
            //        var ccc = aaa - bbb;
            //        Console.WriteLine($"{news}:{ccc}");
            //    }
            //}

            //var result=new RankDTO
            //{
            //    ComicId=newrank.,
            //}

            //var clickcount = _repository.GetAll<ClickRecord>().GroupBy(c => c.ComicId).Select(c => c.Count(gp=>gp.ComicId==c.Key));
            //foreach(var index in clickcount)
            //{
            //    return index;
            //}

            //return from clickrecord in _repository.GetAll<ClickRecord>()
            //       join comic in _repository.GetAll<Comic>()
            //       on clickrecord.ComicId equals comic.ComicId
            //       join comicTagList in _repository.GetAll<ComicTagList>()
            //       on comic.ComicId equals comicTagList.ComicId
            //       join comicTag in _repository.GetAll<ComicTag>()
            //       on comicTagList.TagId equals comicTag.TagId
            //       where comicTag.IsMainTag == true
            //       select new RankViewModel
            //       {
            //           ComicId = comic.ComicId,
            //           ComicName = comic.ComicChineseName,
            //           ComicNameImage = comic.ComicNameImage,
            //           Introduction = comic.Introduction.Substring(0, 50),
            //           ComicFigure = comic.ComicFigure,
            //           BgCover = comic.BgCover,
            //           BgColor = comic.BgColor,
            //           TagName = comicTag.TagName,
            //           //ClickCount = clickcount;
            //       };
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
