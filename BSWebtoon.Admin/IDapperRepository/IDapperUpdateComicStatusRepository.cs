using BSWebtoon.Admin.Repository;
using BSWebtoon.Model.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace BSWebtoon.Admin.IDapperRepository
{
    public interface IDapperUpdateComicStatusRepository : IDapperGenericRepository<Comic>
    {
    }
    public class DapperUpdateComicStatusRepository :
        DapperBaseRepository,
        IDapperUpdateComicStatusRepository
    {
        public DapperUpdateComicStatusRepository(IDbConnection conn) : base(conn)
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
            return _conn.Query<Comic>(@"Select 
                    ComicId,
                    PublishDate,
                    AuditType,
                    ComicStatus
                    from Comic");
        }

        public Comic SelectById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Update(Comic entity)
        {
            return _conn.Execute(@"UPDATE Comic
                                    SET ComicStatus = @ComicStatus
                                    WHERE ComicId = @ComicId"
                                , entity);
        }
    }
}
