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
        private static string _connectionStr = "Server=(localdb)\\mssqllocaldb;Database=BS;Trusted_Connection=True;MultipleActiveResultSets=true";
        private readonly BSWebtoonContext _context;
        private readonly BSRepository _repository;
        public SearchService(BSWebtoonContext context, BSRepository repository)
        {
            _context = context;
            _repository = repository;
        }
        public List<SearchDTO> FindComic(string searchcomic)
        {

            var result = new List<SearchDTO>();

            using (SqlConnection conn = new SqlConnection(_connectionStr))
            {
                string sql = @$"SELECT T.TagName,C.*
                               FROM  ComicTagList  TL 
                               INNER JOIN  Comic C ON  TL.ComicId= C.ComicId
                               INNER JOIN ComicTag T ON T.TagId=TL.TagId
                               WHERE  T.TagName LIKE N'%{searchcomic}%' or C.ComicChineseName  LIKE N'%{searchcomic}%'";
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
