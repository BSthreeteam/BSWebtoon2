using BSWebtoon.Admin.Repository;
using BSWebtoon.Model.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace BSWebtoon.Admin.IDapperRepository
{
    public interface IDapperMemberRepository : IDapperGenericRepository<Member>
    {
        /// <summary>
        /// 找某會員編號
        /// </summary>
        IEnumerable<Member> SelectMember(int? MemberId);

    }
    public class DapperMemberRepository : DapperBaseRepository, IDapperMemberRepository
    {
        public DapperMemberRepository(IDbConnection conn) : base(conn)
        {
        }

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

            return _conn.Query<Member>(@"select M.NameIdentifier,M.AccountName,M.NickName,M.Balance,L.LoginTypeName,M.Email
                                          from Member M
                                         inner join LoginType L on L.LoginTypeId=M.LoginTypeId");

        }

        public Member SelectById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Member> SelectMember(int? MemberId)
        {
            throw new System.NotImplementedException();
        }

        public int Update(Member entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
