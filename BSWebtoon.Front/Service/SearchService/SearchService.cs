using BSWebtoon.Front.Models.DTO.Search;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using Dapper;
using System.Linq;

namespace BSWebtoon.Front.Service.SearchService
{
    public class SearchService : ISearchService
    {
        private static string _connectionStr = "Data Source=bswebtoon.database.windows.net;Initial Catalog=BSWebtoonDb;User ID=bs;Password=P@ssword;Encrypt=True;Trusted_Connection=False;MultipleActiveResultSets=true;";
        private readonly BSWebtoonDbContext _context;
        private readonly BSRepository _repository;
        public SearchService(BSWebtoonDbContext context, BSRepository repository)
        {
            _context = context;
            _repository = repository;
        }
        public List<SearchDTO> FindComic(string searchcomic)
        {
            if (searchcomic == null)
            {
                var result = new List<SearchDTO>(); 
                return result;
            }
            else
            {
                var result = new List<SearchDTO>();

                using (SqlConnection conn = new SqlConnection(_connectionStr))
                {
                    string sql = @$"SELECT DISTINCT C.*
                                   FROM  ComicTagList  TL 
                                   INNER JOIN  Comic C ON  TL.ComicId= C.ComicId
                                   INNER JOIN ComicTag T ON T.TagId=TL.TagId
                                   WHERE  T.TagName LIKE N'%{searchcomic}%' or C.ComicChineseName  LIKE N'%{searchcomic}%' AND C.AuditType=1";
                    var ans = conn.Query<SearchDTO>(sql).ToList();

                    foreach (var item in ans)
                    {
                        result.Add(new SearchDTO
                        {
                            ComicId = item.ComicId,
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
                return result;

            }

        }

    }
}
