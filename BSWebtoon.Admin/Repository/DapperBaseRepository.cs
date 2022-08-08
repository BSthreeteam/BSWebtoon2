using System.Data;

namespace BSWebtoon.Admin.Repository
{
    public class DapperBaseRepository
    {
        //protected 使得子類別 有存取權限 
        protected readonly IDbConnection _conn;
        public DapperBaseRepository(IDbConnection conn)
        {
            _conn = conn;
        }
    }
}
