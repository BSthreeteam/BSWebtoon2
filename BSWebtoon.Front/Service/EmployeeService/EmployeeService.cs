using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System;
using System.Collections.Generic;

namespace BSWebtoon.Front.Service.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly BSWebtoonContext _context;
        private readonly BSRepository _repository;
        public EmployeeService(BSWebtoonContext context, BSRepository repository)
        {
            _context = context;
            _repository = repository;
            //ActivityCreate();
        }
        public void EmployeeCreate()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {EmployeeName="Kei" ,HireDate=new DateTime(2022, 6, 27), Account="lkk975038781@hmail.com",Password="123456789zxc"},
                new Employee {EmployeeName="Joe" ,HireDate=new DateTime(2022, 6, 27), Account="lkk975036543@hmail.com",Password="098765432zxcvbn"},
            };
            foreach(var e in employees)
            {
                _repository.Create(e);
                //_repository.Delete(e);
            }
            _repository.SaveChange();
            //var employees = new Employee() {EmployeeId=2 ,EmployeeName = "Kei", HireDate = new DateTime(2022, 6, 27), Account = "lkk975036543@hmail.com", Password = "098765432zxcvbn" };
            //_repository.Delete(employees);

        }
    }
}
