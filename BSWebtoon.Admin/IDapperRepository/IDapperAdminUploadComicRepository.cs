using BSWebtoon.Admin.Repository;
using BSWebtoon.Model.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace BSWebtoon.Admin.IDapperRepository
{
    public interface IDapperAdminUploadComicRepository : IDapperGenericRepository<Comic>
    {

    }
    public class DapperAdminUploadComicRepository : DapperBaseRepository, IDapperAdminUploadComicRepository
    {
        public DapperAdminUploadComicRepository(IDbConnection conn) : base(conn)
        {
        }

        public int Create(Comic entity)
        {
            return _conn.Execute(@"
                INSERT INTO Comic(ComicChineseName,ComicEnglishName,ComicNameImage,BgCover,ComicFigure,
                ComicWeekFigure,BgColor,PublishDate,UpdateWeek,Painter,Author,Introduction,
                AuditEmployeeId,ComicStatus,Publisher,LastPublishDate,AuditType)
                VALUES(@ComicChineseName,@ComicEnglishName,@ComicNameImage,@BgCover,@ComicFigure,
                @ComicWeekFigure,@BgColor,@PublishDate,@UpdateWeek,@Painter,@Author,@Introduction
                ,@AuditEmployeeId,@ComicStatus,@Publisher,@LastPublishDate,@AuditType)"
            , entity);
        }

        public int Delete(Comic entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Comic> SelectAll()
        {
            return _conn.Query<Comic>(@"Select ComicId from Comic");
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
