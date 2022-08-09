using BSWebtoon.Admin.Repository;
using BSWebtoon.Model.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace BSWebtoon.Admin.IDapperRepository
{
    public interface IDapperActivityRepository : IDapperGenericRepository<Activity>
    {

    }
    public class DapperActivityRepository :
        DapperBaseRepository, //繼承這個基底類別
        IDapperActivityRepository
    {
        public DapperActivityRepository(IDbConnection conn) : base(conn)
        { }

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
                                ,entity);
        }
    }
}
