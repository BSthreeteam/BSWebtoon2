using BSWebtoon.Admin.Repository;
using BSWebtoon.Model.Models;
using System.Collections.Generic;

namespace BSWebtoon.Admin.IDapperRepository
{
    public interface IDapperEmployeeRepository :IDapperGenericRepository<Employee>
    {
        /// <summary>
        /// 找某員工編號的下屬
        /// </summary>
        IEnumerable<Employee> SelectSubordinates(int? employeeId);
    }
}
