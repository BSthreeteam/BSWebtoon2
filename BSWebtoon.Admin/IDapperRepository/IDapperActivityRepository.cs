using BSWebtoon.Admin.Models.DTO.Activitys;
using BSWebtoon.Admin.Repository;
using BSWebtoon.Model.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;

namespace BSWebtoon.Admin.IDapperRepository
{
    public interface IDapperActivityRepository : IDapperGenericRepository<Activity>
    {
        IEnumerable<Activity> SelectActivity(int? ActivityId);
        //擴充一個契約
        int UpdateImg(Activity entity);
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

            var AllActivity = @" SELECT 
	a.ActivityId,
	a.ActivityName,
	a.ActivityStartTime,
	a.ActivityEndTime,
	a.ActivityImage,
	a.ActivityBgColor,
	a.ActivityContent,
    a.CreateTime,
	e.EmployeeName as ActivityEmployeeName
FROM Activity a
INNER JOIN Employee e ON e.EmployeeId = a.PrincipalEmployee";

            return _conn.Query<ReadActivityDTO> (AllActivity);
        }

        public Activity SelectById(int id)
        {
            throw new System.NotImplementedException();
        }


        public int Update(Activity entity)
        {
            ////SqlMapper.AddTypeMap(typeof(DateTime), System.Data.DbType.DateTime2);
            //var start = entity.ActivityStartTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            //var end = entity.ActivityEndTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            //var zero = "0001-01-01 00:00:00";

            //if(entity.ActivityImage !=null)
            //{
            //    _conn.Execute(

            //}

            //@"
            //    UPDATE Activity 
            //    SET (ActivityImage, ActivityStartTime)
            //    VALUES ( 'qwe' , '2222-11-22' )
            //    WHERE ActivityId = @ActivityId
            //"
            //var rows = _conn.Execute(@"
            //    UPDATE Activity 
            //    SET ActivityName = @ActivityName,
            //        ActivityBgColor = @ActivityBgColor,
            //        ActivityContent = @ActivityContent,
            //        ActivityStartTime = @ActivityStartTime, 
            //        ActivityEndTime = @ActivityEndTime
            //    WHERE ActivityId = @ActivityId
            //", entity);

            //if(entity.ActivityImage != null)
            //{
            //    _conn.Execute(@"
            //        UPDATE Activity 
            //        SET ActivityImage = @ActivityImage,
            //        WHERE ActivityId = @ActivityId
            //    ", entity);
            //}


            return _conn.Execute(@"
                UPDATE Activity 
                SET ActivityName = @ActivityName,
                    ActivityBgColor = @ActivityBgColor,
                    ActivityContent = @ActivityContent,
                    ActivityStartTime = @ActivityStartTime, 
                    ActivityEndTime = @ActivityEndTime
                WHERE ActivityId = @ActivityId
            ", entity);

            //UPDATE Activity
            //    SET ActivityName = case when @ActivityName IS NOT NULL then @ActivityName end,
            //        ActivityBgColor = case when @ActivityBgColor IS NOT NULL then @ActivityBgColor end,
            //        ActivityContent =  case when @ActivityContent IS NOT NULL then @ActivityContent end,
            //        ActivityImage = case when @ActivityImage IS NOT NULL then @ActivityImage end,
            //        ActivityStartTime = case when @ActivityStartTime IS NOT NULL then @ActivityStartTime end,
            //        ActivityEndTime = case when @ActivityEndTime IS NOT NULL then @ActivityEndTime end
            //    WHERE ActivityId = @ActivityId

            //ActivityBgColor = case when @ActivityBgColor IS NOT NULL then @ActivityBgColor end,
            //ActivityContent =  case when @ActivityContent IS NOT NULL then @ActivityContent end
        }

        public int UpdateImg(Activity entity)
        {
            if (entity.ActivityImage != null)
            {
                _conn.Execute(@"
                    UPDATE Activity 
                    SET ActivityImage = @ActivityImage
                    WHERE ActivityId = @ActivityId
                ", entity);
            }
            return 1;
        }
    }
}
