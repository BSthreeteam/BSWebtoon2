using BSWebtoon.Admin.Models.DTO;
using BSWebtoon.Admin.Repository;
using BSWebtoon.Model.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
            var result = @"select M.MemberId,M.AccountName,M.NickName,M.Balance,M.CreateTime ,M.Email,L.LoginTypeName
                           from Member M
                           inner join LoginType L on L.LoginTypeId=M.LoginTypeId";


                return _conn.Query<MemberDTO>(result);

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
