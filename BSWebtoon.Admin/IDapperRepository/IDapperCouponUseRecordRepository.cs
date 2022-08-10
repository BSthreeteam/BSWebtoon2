using BSWebtoon.Admin.Repository;
using BSWebtoon.Model.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace BSWebtoon.Admin.IDapperRepository
{
    public interface IDapperCouponUseRecordRepository : IDapperGenericRepository<CouponUsedRecord>
    {
    }
    public class DapperCouponUseRecordRepository :
        DapperBaseRepository,
        IDapperCouponUseRecordRepository
    {
        public DapperCouponUseRecordRepository(IDbConnection conn) : base(conn)
        { }

        public int Create(CouponUsedRecord entity)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(CouponUsedRecord entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CouponUsedRecord> SelectAll()
        {
            return _conn.Query<CouponUsedRecord>(@"Select * from CouponUsedRecord");
        }

        public CouponUsedRecord SelectById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Update(CouponUsedRecord entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
