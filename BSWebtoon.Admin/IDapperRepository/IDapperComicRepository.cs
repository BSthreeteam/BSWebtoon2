using BSWebtoon.Admin.Repository;
using BSWebtoon.Model.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace BSWebtoon.Admin.IDapperRepository
{
    public interface IDapperComicRepository : IDapperGenericRepository<Comic>
    {
    }
    public class DapperComicRepository :
        DapperBaseRepository,
        IDapperComicRepository
    {
        public DapperComicRepository(IDbConnection conn) : base(conn)
        {
        }

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
            return _conn.Query<Comic>(@"Select ComicId,AuditType from Comic");
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
