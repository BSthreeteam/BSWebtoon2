using BSWebtoon.Admin.Models.DTO;
using BSWebtoon.Admin.Repository;
using BSWebtoon.Model.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace BSWebtoon.Admin.IDapperRepository
{
    public interface IDapperDashRankRepository : IDapperGenericRepository<ClickRecord>
    {

    }
    public class DapperDashRankRepository :
        DapperBaseRepository, //繼承這個基底類別
        IDapperDashRankRepository
    {
        public DapperDashRankRepository(IDbConnection conn) : base(conn)
        { }

        public int Create(ClickRecord entity)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(ClickRecord entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ClickRecord> SelectAll()
        {
            return _conn.Query<DashboardTopRankDTO>(@"SELECT top 5  COUNT(CR.ComicId) AS ClickRecordCount,C.ComicChineseName
                                                      FROM ClickRecord CR 
                                                      inner join Comic C on C.ComicId =CR.ComicId 
                                                      GROUP BY C.ComicChineseName
                                                      order by  ClickRecordCount desc");
        }

        public ClickRecord SelectById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Update(ClickRecord entity)
        {
            throw new System.NotImplementedException();
        }
    }   
}
