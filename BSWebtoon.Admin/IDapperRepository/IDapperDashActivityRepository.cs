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
        /// <summary>
        /// 尋找活動數
        /// </summary>
        IEnumerable<Activity> SelectActivity(int? ActivityId);
    }
    public class DapperDashActivityRepository : DapperBaseRepository, IDapperDashActivityRepository
    {
        public DapperDashActivityRepository(IDbConnection conn) : base(conn)
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

        public IEnumerable<Activity> SelectActivity(int? ActivityId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Activity> SelectAll()
        {
            var result = @"select count(a.ActivityId) as ActivityCount
                                                       from Activity a
                                                       where a.IsDelete=0";
            return _conn.Query<DashboardActicityDTO>(result);
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
