using BSWebtoon.Admin.Repository;
using BSWebtoon.Model.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace BSWebtoon.Admin.IDapperRepository
{
    public interface IDapperEpisodeRepository : IDapperGenericRepository<Episode>
    {
    }
    public class DapperEpisodeRepository :
        DapperBaseRepository,
        IDapperEpisodeRepository
    {
        public DapperEpisodeRepository(IDbConnection conn) : base(conn)
        {
        }

        public int Create(Episode entity)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(Episode entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Episode> SelectAll()
        {
            return _conn.Query<Episode>(@"Select
                    EpId,
                    ComicId,
                    UploadTime,
                    AuditType,
                    IsCountdownCoupon,
                    IsFree
                    from Episode");
        }

        public Episode SelectById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Update(Episode entity)
        {
            return _conn.Execute(@"UPDATE Episode
                                    SET IsCountdownCoupon = @IsCountdownCoupon
                                    WHERE EpId = @EpId"
                                , entity);
        }
    }
}
