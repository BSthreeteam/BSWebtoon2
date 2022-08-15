using BSWebtoon.Admin.Models.DTO;
using BSWebtoon.Admin.Repository;
using BSWebtoon.Model.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace BSWebtoon.Admin.IDapperRepository
{
    public interface IDapperDashMemberRepository : IDapperGenericRepository<Member>
    {

    }
    public class DapperDashMemberRepository :
        DapperBaseRepository, //繼承這個基底類別
        IDapperDashMemberRepository
    {
        public DapperDashMemberRepository(IDbConnection conn) : base(conn)
        { }

        public int Create(Member entity)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(Member entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Member> SelectAll()
        {
            return _conn.Query<DashboardMemberDTO>(@"select count(M.MemberId) as MemberCount
                                                       from Member M");
        }

        public Member SelectById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Update(Member entity)
        {
            throw new System.NotImplementedException();
        }
    }   
}
