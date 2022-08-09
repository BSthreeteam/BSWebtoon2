using BSWebtoon.Admin.Repository;
using BSWebtoon.Model.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace BSWebtoon.Admin.IDapperRepository
{
    public interface IDapperActivityRepository : IDapperGenericRepository<Activity> 
    {
        IEnumerable<Activity> SelectActivity(int? ActivityId);
    }
    /* DapperBaseRepository 繼承這個基底類別*/  /* IDapperActivityRepository 實作這個介面，就會必須有5通用+1專用個方法*/
    public class DapperActivityRepository : DapperBaseRepository, IDapperActivityRepository 
    {
        public DapperActivityRepository(IDbConnection conn) : base(conn)
        {

        }

        

        public int Create(Activity entity)
        {
            
            return _conn.Execute(@"
                INSERT INTO Activity ( ActivityName , ActivityStartTime , ActivityEndTime ,ActivityBgColor, ActivityImage , ActivityContent, PrincipalEmployee , CreateTime  ,IsDelete) 
                VALUES (@ActivityName, @ActivityStartTime, @ActivityEndTime , @ActivityBgColor , @ActivityImage , @ActivityContent , @PrincipalEmployee , @CreateTime , @IsDelete)
            ", entity);
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

            return _conn.Query<Activity>(@" Select ActivityName,
                                                   ActivityStartTime,
                                                   ActivityEndTime,
                                                   ActivityImage,
                                                   ActivityBgColor,
                                                   ActivityContent,
                                                   PrincipalEmployee,
                                                   CreateTime,
                                                   IsDelete
                                            from Activity");
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
