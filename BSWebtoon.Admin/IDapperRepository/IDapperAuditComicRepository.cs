using BSWebtoon.Admin.Models.DTO;
using BSWebtoon.Admin.Repository;
using BSWebtoon.Model.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BSWebtoon.Admin.IDapperRepository
{
    public interface IDapperAuditComicRepository : IDapperGenericRepository<Comic>
    {
        /// <summary>
        /// 找某會員編號
        /// </summary>
        //IEnumerable<Member> SelectMember(int? MemberId);

    }
    public class DapperAuditComicRepository : DapperBaseRepository, IDapperAuditComicRepository
    {
        public DapperAuditComicRepository(IDbConnection conn) : base(conn)
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
            var result = @"select C.ComicChineseName,C.ComicId,C.Publisher,C.UpdateWeek,C.PublishDate,C.AuditType
                           from Comic C";


            return _conn.Query<Comic>(result);

        }

        public Comic SelectById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Comic> SelectMember(int? MemberId)
        {
            throw new System.NotImplementedException();
        }

        public int Update(Comic entity)
        {
            throw new System.NotImplementedException();
        }
    }
}