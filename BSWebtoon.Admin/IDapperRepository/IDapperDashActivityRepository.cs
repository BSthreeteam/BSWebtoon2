using BSWebtoon.Admin.Models.DTO;
using BSWebtoon.Admin.Repository;
using BSWebtoon.Model.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace BSWebtoon.Admin.IDapperRepository
{
    public interface IDapperDashActivityRepository : IDapperGenericRepository<Activity>
    {

    }
    public class DapperDashActivityRepository :
        DapperBaseRepository, //繼承這個基底類別
        IDapperDashActivityRepository
    {
        public DapperDashActivityRepository(IDbConnection conn) : base(conn)
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
            return _conn.Query<DashboardActicityDTO>(@"select count(a.ActivityId) as ActivityCount
                                                       from Activity a
                                                       where a.IsDelete=0");
        }

        public Activity SelectById(int id)
        {
            throw new System.NotImplementedException();
        }


        public int Update(Activity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
