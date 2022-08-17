using BSWebtoon.Admin.Models.DTO;
using BSWebtoon.Admin.Repository;
using BSWebtoon.Model.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace BSWebtoon.Admin.IDapperRepository
{
    public interface IDapperDashComicRepository : IDapperGenericRepository<Comic>
    {

    }
    public class DapperDashComicRepository :
        DapperBaseRepository, //繼承這個基底類別
        IDapperDashComicRepository
    {
        public DapperDashComicRepository(IDbConnection conn) : base(conn)
        { }

        public int Create(Comic entity)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(Comic entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Comic> SelectAll()
        {
            return _conn.Query<DashboardComicDTO>(@"select count(c.ComicId) as ComicCount
                                                       from Comic c");
        }

        public Comic SelectById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Update(Comic entity)
        {
            throw new System.NotImplementedException();
        }
    }   
}
