using BSWebtoon.Admin.Repository;
using BSWebtoon.Model.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace BSWebtoon.Admin.IDapperRepository
{
    public interface IDapperCouponRepository : IDapperGenericRepository<Coupon>
    {
    }
    public class DapperCouponRepository :
        DapperBaseRepository,
        IDapperCouponRepository
    {
        public DapperCouponRepository(IDbConnection conn) : base(conn)
        { }

        public int Create(Coupon entity)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(Coupon entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Coupon> SelectAll()
        {
            return _conn.Query<Coupon>(@"Select * from Coupon");
        }

        public Coupon SelectById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Update(Coupon entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
