using BSWebtoon.Admin.Repository;
using BSWebtoon.Model.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace BSWebtoon.Admin.IDapperRepository
{
    public interface IDapperAdminComicTagListRepository : IDapperGenericRepository<ComicTagList>
    {

    }
    public class DapperAdminComicTagListRepository : DapperBaseRepository, IDapperAdminComicTagListRepository
    {
        public DapperAdminComicTagListRepository(IDbConnection conn) : base(conn)
        {
        }

        public int Create(ComicTagList entity)
        {
            return _conn.Execute(@"
                INSERT INTO ComicTagList(TagId,ComicId)
                VALUES(@TagId,@ComicId)", entity);
        }

        public int Delete(ComicTagList entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ComicTagList> SelectAll()
        {
            return _conn.Query<ComicTagList>(@"Select * from ComicTagList");
        }

        public ComicTagList SelectById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Update(ComicTagList entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
