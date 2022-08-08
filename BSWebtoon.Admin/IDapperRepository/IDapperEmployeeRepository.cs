using BSWebtoon.Admin.Repository;
using BSWebtoon.Model.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace BSWebtoon.Admin.IDapperRepository
{
    public interface IDapperEmployeeRepository :IDapperGenericRepository<Employee>
    {
        /// <summary>
        /// 找某員工編號的下屬
        /// </summary>
        IEnumerable<Employee> SelectSubordinates(int? employeeId);

    }
    public class DapperEmployeeRepository :
        DapperBaseRepository, //繼承這個基底類別
        IDapperEmployeeRepository //實作這個介面，就會必須有5通用+1專用個方法
    {
        public DapperEmployeeRepository(IDbConnection conn) : base(conn)
        { }

        public int Create(Employee entity)
        {
            throw new System.NotImplementedException();
        //    return _conn.Execute(@"
        //    INSERT INTO Employees(FirstName, LastName, Title, Country) 
        //    VALUES ( @FirstName, @LastName, @Title, @Country)
        //", entity);
        }
        public int Update(Employee entity)
        {
            throw new System.NotImplementedException();
        //    return _conn.Execute(@"
        //    UPDATE Employees 
        //    SET FirstName=@FirstName, LastName=@LastName, Title=@Title, Country=@Country
        //    WHERE EmployeeID=@EmployeeID
        //", entity);
        }
        public int Delete(Employee entity)
        {
            throw new System.NotImplementedException();
        //    return _conn.Execute(@"
        //    DELETE FROM Employees
        //    WHERE EmployeeID = @EmployeeID
        //",
        //    new { entity.EmployeeId });  //匿名類別 若省略屬性名稱，會自動判斷該取什麼名字
        //                                 //new { EmployeeID = entity.EmployeeID }); //一般寫法
        }


        public IEnumerable<Employee> SelectAll()
        {
            return _conn.Query<Employee>(@" Select EmployeeName,HireDate,Account
                                            from Employee");
        }

        public Employee SelectById(int id)
        {
            throw new System.NotImplementedException();
        //    return _conn.QueryFirstOrDefault<Employee>(@"
        //    SELECT * FROM Employees WHERE EmployeeID= @id
        //",
        //    new { id }); //匿名類別 若省略屬性名稱，會自動判斷該取什麼名字
        //                 //new { id = id }); //一般寫法
        }

        public IEnumerable<Employee> SelectSubordinates(int? employeeId)
        {
            throw new System.NotImplementedException();
        //    return _conn.Query<Employee>(@"
        //    SELECT * FROM Employees WHERE ReportsTo= @employeeId
        //",
        //    new { employeeId }); //匿名類別 若省略屬性名稱，會自動判斷該取什麼名字
        }
    }
}
