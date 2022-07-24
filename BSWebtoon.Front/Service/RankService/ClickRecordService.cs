using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using BSWebtoon.Front.Models.DTO.Rank;
using static BSWebtoon.Front.Models.DTO.Rank.AllTagRankDTO;
using Dapper;

namespace BSWebtoon.Front.Service.RankService
{
    public class ClickRecordService : IClickRecordService
    {
        private static string _connectionStr = "Server=(localdb)\\mssqllocaldb;Database=BS;Trusted_Connection=True;MultipleActiveResultSets=true";
        private readonly BSWebtoonContext _context;
        private readonly BSRepository _repository;
        public ClickRecordService(BSWebtoonContext context, BSRepository repository)
        {
            _context = context;
            _repository = repository;
        }
        public void ClickRecordCreate()
        {
            var clickRecod = new List<ClickRecord> {
                new ClickRecord {/*ClickRecordId=1,*/ComicId=1,CreateTime=new DateTime(2022,07,21),MemberId=6},
                new ClickRecord {/*ClickRecordId=2,*/ComicId=1,CreateTime=new DateTime(2022,07,23),MemberId=3},
                new ClickRecord {/*ClickRecordId=3,*/ComicId=3,CreateTime=new DateTime(2022,07,18),MemberId=2},
                new ClickRecord {/*ClickRecordId=4,*/ComicId=15,CreateTime=new DateTime(2022,07,18),MemberId=15},
                new ClickRecord {/*ClickRecordId=5,*/ComicId=1,CreateTime=new DateTime(2022,07,19),MemberId=17},
                new ClickRecord {/*ClickRecordId=6,*/ComicId=5,CreateTime=new DateTime(2022,07,20),MemberId=4},
                new ClickRecord {/*ClickRecordId=7,*/ComicId=7,CreateTime=new DateTime(2022,07,17),MemberId=7},
                new ClickRecord {/*ClickRecordId=8,*/ComicId=14,CreateTime=new DateTime(2022,07,15),MemberId=18},
                new ClickRecord {/*ClickRecordId=9,*/ComicId=2,CreateTime=new DateTime(2022,07,25),MemberId=16},
                new ClickRecord {/*ClickRecordId=10,*/ComicId=3,CreateTime=new DateTime(2022,07,27),MemberId=19},
                new ClickRecord {/*ClickRecordId=11,*/ComicId=4,CreateTime=new DateTime(2022,07,29),MemberId=10},
                new ClickRecord {/*ClickRecordId=12,*/ComicId=17,CreateTime=new DateTime(2022,07,24),MemberId=16},
                new ClickRecord {/*ClickRecordId=13,*/ComicId=8,CreateTime=new DateTime(2022,07,22),MemberId=12},
                new ClickRecord {/*ClickRecordId=14,*/ComicId=10,CreateTime=new DateTime(2022,07,23),MemberId=5},
                new ClickRecord {/*ClickRecordId=15,*/ComicId=16,CreateTime=new DateTime(2022,07,31),MemberId=7},
                new ClickRecord {/*ClickRecordId=16,*/ComicId=17,CreateTime=new DateTime(2022,07,26),MemberId=16},
                new ClickRecord {/*ClickRecordId=17,*/ComicId=18,CreateTime=new DateTime(2022,07,29),MemberId=12},
                new ClickRecord {/*ClickRecordId=18,*/ComicId=6,CreateTime=new DateTime(2022,07,30),MemberId=2},
                new ClickRecord {/*ClickRecordId=19,*/ComicId=1,CreateTime=new DateTime(2022,07,21),MemberId=8},
                new ClickRecord {/*ClickRecordId=20,*/ComicId=2,CreateTime=new DateTime(2022,07,23),MemberId=9},
            };
            foreach (ClickRecord click in clickRecod)
            {
                _repository.Create(click);

            }
            _repository.SaveChange();
        }


        public List<AllTagRankDTO> ReadAllRank()
        {
            var oldClickRecords = _repository.GetAll<ClickRecord>()
                .Where(c => c.CreateTime < new DateTime(2022, 8, 4).AddDays(-7) && c.CreateTime >= new DateTime(2022, 8, 4).AddDays(-14));

            var oldGroupBy = oldClickRecords
                .GroupBy(c => c.ComicId)
                .OrderByDescending(c => c.Count(gp => gp.ComicId == c.Key))
                .ThenBy(c => c.Key).Select(c => c.Key);


            var newClickRecords = _repository.GetAll<ClickRecord>()
                .Where(c => c.CreateTime < new DateTime(2022, 8, 4) && c.CreateTime >= new DateTime(2022, 8, 4).AddDays(-7));

            var newGroupBy = newClickRecords
                .GroupBy(c => c.ComicId)
                .OrderByDescending(c => c.Count(gp => gp.ComicId == c.Key))
                .ThenBy(c => c.Key).Select(c => c.Key);


            var newrank = _repository.GetAll<Comic>().Where(n => newGroupBy.Any(nc => nc == n.ComicId) && n.AuditType == 1).ToList();//.Select(n => n.ComicId);


            List<int> oldSource = new List<int>();
            List<int> newSource = new List<int>();

            oldSource.AddRange(oldGroupBy);
            newSource.AddRange(newGroupBy);



            var result = newrank.Select(comicrank => new AllTagRankDTO
            {
                ComicId = comicrank.ComicId,
                ComicName = comicrank.ComicChineseName,
                ComicNameImage = comicrank.ComicNameImage,
                ComicWeekFigure = comicrank.ComicWeekFigure,
                ComicFigure = comicrank.ComicFigure,
                BgCover = comicrank.BgCover,
                Introduction = comicrank.Introduction,
                BannerVideoWeb = comicrank.BannerVideoWeb,
                Diff = oldSource.IndexOf(comicrank.ComicId) == -1 ? 0 : oldSource.IndexOf(comicrank.ComicId) + 1 - newSource.IndexOf(comicrank.ComicId) + 1
            }).ToList();
            return result;





            //TagName= mainTag.TagName,
            //原本在74行
            //foreach(var aaa in newrank)
            //{
            //    var tagListSource = _repository.GetAll<ComicTagList>().Where(t => t.ComicId == aaa.ComicId);

            //};
            //var bbb = tagListSource.ToList();

            //var tagListSource = _repository.GetAll<ComicTagList>().Where(t => newrank.Any(nc => nc.ComicId == t.ComicId)).Select(t => t.TagId).ToList();

            //var mainTag = _repository.GetAll<ComicTag>().Where(x => tagListSource.Any(y => y == x.TagId)).First(x => x.IsMainTag);

            //var tagListSource = _repository.GetAll<ComicTagList>().Where(t => t.ComicId == newrank.Select(n => n.ComicId))).Select(t => t.TagId).ToList();
            //var mainTag = _repository.GetAll<ComicTag>().Where(x => tagListSource.Any(y => y.TagId == x.TagId)).First(x => x.IsMainTag);



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


        public List<CategoryRankDTO> ReadOtherTagRank(int id)
        {

            var result = new List<CategoryRankDTO>();

            using (SqlConnection conn = new SqlConnection(_connectionStr))
            {
                //每部漫畫主要的標籤名稱
                string sql = @$"SELECT T.TagName,c.*
                               FROM  ComicTagList  TL 
                               INNER JOIN  Comic C ON  TL.ComicId= C.ComicId
                               INNER JOIN ComicTag T ON T.TagId=TL.TagId
                               WHERE T.TagName IN (
				                     SELECT T.TagName
				                     FROM ComicTag T
				                     INNER JOIN ComicTagList  TL ON T.TagId=TL.TagId
				                     WHERE T.IsMainTag=1 
                               ) and   T.TagId= {id}";
                //篩選出T.TagName,comic資料全部 的結果後放到CategoryTagRankDTO的表中
                var tagListResult = conn.Query<CategoryTagRankDTO>(sql);

                //計算排名區間
                var newRankEndDate = new DateTime(2022, 07, 29);
                var newRankStartDate = newRankEndDate.AddDays(-7);//7/22

                var oldRankEndDate = newRankStartDate.AddDays(-1);//7/21
                var oldRankStartDate = oldRankEndDate.AddDays(-6);//7/15


                //找出每個漫畫上上周的點擊數
                string oldClickRecord = @$"SELECT  CR.ComicId, COUNT(CR.ComicId) AS ClickRecordCount
                                          FROM ClickRecord CR 
                                          WHERE  (CR.CreateTime BETWEEN '{oldRankStartDate:yyyyMMdd} 00:00:00.000' AND '{oldRankEndDate:yyyyMMdd} 23:59:59.997' )
                                          GROUP BY CR.ComicId";
                //找出每個漫畫上週的點擊數
                string newClickRecord = @$"SELECT  CR.ComicId, COUNT(CR.ComicId) AS ClickRecordCount
                                          FROM ClickRecord CR 
                                          WHERE  (CR.CreateTime BETWEEN '{newRankStartDate:yyyyMMdd} 00:00:00.000'   AND    '{newRankEndDate:yyyyMMdd} 23:59:59.997' )
                                          GROUP BY CR.ComicId";
                //篩選出每個漫畫上上周的點擊數  的結果後放到ClickRecordRsult的表中
                var oldRankResponse = conn.Query<ClickRecordRsult>(oldClickRecord).ToList();
                //篩選出每個漫畫上周的點擊數 的結果後放到ClickRecordRsult的表中

                var newRankResponse = conn.Query<ClickRecordRsult>(newClickRecord);

                //把每個漫畫上上周的點擊數跟T.TagName,comic資料全部整合成List<Integrate>
                var oldIntergrateList = new List<Integrate>();

                //把每個漫畫上周的點擊數跟T.TagName,comic資料全部整合成List<Integrate>
                var newIntergrateList = new List<Integrate>();

                //藉由CategoryTagRankDTO表中的TagName,comic資料 去做跌代
                foreach (var item in tagListResult)
                {
                    //找出舊排行漫畫的點擊數
                    var oldTemp = oldRankResponse.Where(o => o.ComicId == item.ComicId).FirstOrDefault();
                    //篩選出有在舊排行中的漫畫並把需要的資料放入 Integrate中 
                    if (oldTemp != default)
                    {
                        oldIntergrateList.Add(new Integrate
                        {
                            ComicId = oldTemp.ComicId,
                            TagName = item.TagName,
                            ClickRecordCount = oldTemp.ClickRecordCount,
                            ComicName = item.ComicName,
                            ComicNameImage = item.ComicNameImage,
                            BannerVideoWeb = item.BannerVideoWeb,
                            ComicWeekFigure = item.ComicWeekFigure,
                            BgCover = item.BgCover,
                            AuditType = item.AuditType,
                            Introduction = item.Introduction,
                            ComicFigure = item.ComicFigure,
                        });
                    }

                    //找出新排行漫畫的點擊數
                    var newTemp = newRankResponse.Where(n => n.ComicId == item.ComicId).FirstOrDefault();
                    //篩選出有在新排行中的漫畫並把需要的資料放入 Integrate中 
                    if (newTemp != default)
                    {
                        newIntergrateList.Add(new Integrate
                        {
                            ComicId = newTemp.ComicId,
                            TagName = item.TagName,
                            ClickRecordCount = newTemp.ClickRecordCount,
                            ComicName = item.ComicName,
                            ComicNameImage = item.ComicNameImage,
                            BannerVideoWeb = item.BannerVideoWeb,
                            ComicWeekFigure = item.ComicWeekFigure,
                            BgCover = item.BgCover,
                            AuditType = item.AuditType,
                            Introduction = item.Introduction,
                            ComicFigure = item.ComicFigure,
                        });

                    }

                }

                //把Integrate中的舊排行 進行點擊數的排序，再藉由 TagName分類
                var oldClickGroup = oldIntergrateList.OrderBy(o => o.ClickRecordCount).GroupBy(o => o.TagName);
                //把Integrate中的新排行 進行點擊數的排序，再藉由 TagName分類
                var newClickGroup = newIntergrateList.OrderBy(n => n.ClickRecordCount).GroupBy(n => n.TagName);

                //藉由已排序好且分類過後的新Integrate 去做跌代出Key
                foreach (var newgroup in newClickGroup)
                {
                    //在舊Integrate中尋找與新Integrate 相同的類別的所有資料 
                    var oldTagGroupList = oldClickGroup.Where(o => o.Key == newgroup.Key).FirstOrDefault();
                    //如果舊的有該類別則
                    if (oldTagGroupList != default)
                    {
                        //選擇舊Integrate的漫畫select出相關資訊
                        var oldTagGroup = oldTagGroupList.Select(o => o).ToList();

                        //選擇舊Integrate的漫畫select出漫畫Id
                        var oldComicList = oldTagGroup.Select(o => o.ComicId).ToList();

                        //藉由已排序好且分類過後的新Integrate 去做跌代出成員
                        foreach (var item in newgroup)
                        {
                            //選擇新Integrate的漫畫select出漫畫Id
                            var newComicList = newgroup.Select(n => n.ComicId).ToList();
                            //把我們最終所需的資料放入CategoryRankDTO
                            result.Add(new CategoryRankDTO
                            {
                                ComicId = item.ComicId,
                                ComicName = item.ComicName,
                                BannerVideoWeb = item.BannerVideoWeb,
                                ComicNameImage = item.ComicNameImage,
                                ComicWeekFigure = item.ComicWeekFigure,
                                ComicFigure = item.ComicFigure,
                                Introduction = item.Introduction,
                                BgCover = item.BgCover,
                                AuditType = item.AuditType,
                                //TagName = newgroup.Key,
                                TagName = id.ToString(),
                                //差距排名
                                Diff = oldComicList.IndexOf(item.ComicId) == -1 ? 0 : newComicList.IndexOf(item.ComicId) + 1 - oldComicList.IndexOf(item.ComicId) + 1
                            });
                        }
                    }
                    //如果舊的沒有該類別則
                    else
                    {
                        //藉由已排序好且分類過後的新Integrate 去做跌代出成員
                        foreach (var item in newgroup)
                        {
                            //把我們最終所需的資料放入CategoryRankDTO
                            result.Add(new CategoryRankDTO
                            {
                                ComicId = item.ComicId,
                                ComicName = item.ComicName,
                                BannerVideoWeb = item.BannerVideoWeb,
                                ComicNameImage = item.ComicNameImage,
                                ComicWeekFigure = item.ComicWeekFigure,
                                ComicFigure = item.ComicFigure,
                                Introduction = item.Introduction,
                                BgCover = item.BgCover,
                                AuditType = item.AuditType,
                                //TagName = newgroup.Key,
                                TagName = id.ToString(),
                                //差距排名為new
                                Diff = 0
                            });
                        }
                    }

                }

            }
            return result;

        }




        //public void UpdateRank()
        //{
        //    var updatarank = _repository.GetAll<ClickRecord>().Where(x => x.ClickRecordId == 2).FirstOrDefault();
        //    updatarank.CreateTime = new DateTime(2021, 07, 24);
        //    _repository.Update(updatarank);
        //    _repository.SaveChange();
        //}
    }



}
