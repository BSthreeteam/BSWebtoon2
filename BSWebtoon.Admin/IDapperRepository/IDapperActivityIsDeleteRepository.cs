using BSWebtoon.Admin.Repository;
using BSWebtoon.Model.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace BSWebtoon.Admin.IDapperRepository
{
    public interface IDapperActivityIsDeleteRepository : IDapperGenericRepository<Activity>
    {
    }
    public class DapperActivityIsDeleteRepository :
        DapperBaseRepository,
        IDapperActivityIsDeleteRepository
    {
        public DapperActivityIsDeleteRepository(IDbConnection conn) : base(conn)
        {
        }

        public int Create(Activity entity)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(Activity entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Activity> SelectAll()
        {
            return _conn.Query<Activity>(@"Select * from Activity");
        }

        public Activity SelectById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Update(Activity entity)
        {
            return _conn.Execute(@"UPDATE Activity
                                    SET IsDelete = @IsDelete
                                    WHERE ActivityId = @ActivityId"
                                , entity);
        }
    }
}
