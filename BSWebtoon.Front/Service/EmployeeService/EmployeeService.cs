using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System;
using System.Collections.Generic;

namespace BSWebtoon.Front.Service.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly BSRepository _repository;
        public EmployeeService(BSWebtoonDbContext context, BSRepository repository)
        {
            _repository = repository;
        }
        public void EmployeeCreate()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {EmployeeName="Kei" ,HireDate=new DateTime(2022, 6, 27), Account="lkk975038781@gmail.com",Password="123456789zxc"},
                new Employee {EmployeeName="Jimmy" ,HireDate=new DateTime(2022, 6, 25), Account="Jimmy975036543@gmail.com",Password="098765432zxcvbn"},
                new Employee {EmployeeName="Ben" ,HireDate=new DateTime(2022, 6, 23), Account="Ben975036543@gmail.com",Password="09876555zxcvbn"},
                new Employee {EmployeeName="Abraham" ,HireDate=new DateTime(2022, 6, 24), Account="Abraham975036543@gmail.com",Password="123765432zxcvbn"},
                new Employee {EmployeeName="Arthur" ,HireDate=new DateTime(2022, 6, 20), Account="Arthur975036543@hmail.com",Password="092345432zxcvbn"},

                new Employee {EmployeeName="Anke" ,HireDate=new DateTime(2022, 6, 23), Account="Anke975036543@hmail.com",Password="098723432zxcvbn"},
                new Employee {EmployeeName="Basil" ,HireDate=new DateTime(2022, 6, 27), Account="Basil975036543@hmail.com",Password="033765432zxcvbn"},
                new Employee {EmployeeName="Bill" ,HireDate=new DateTime(2022, 6, 27), Account="Bill975036543@hmail.com",Password="333765432zxcvbn"},
                new Employee {EmployeeName="Billy" ,HireDate=new DateTime(2022, 6, 22), Account="Billy975036543@hmail.com",Password="095555432zxcvbn"},
                new Employee {EmployeeName="Brandon" ,HireDate=new DateTime(2022, 6, 12), Account="Brandon975036543@hmail.com",Password="091115432zxcvbn"},

                new Employee {EmployeeName="Cary" ,HireDate=new DateTime(2022, 2, 10), Account="Cary975036543@hmail.com",Password="098700032zxcvbn"},
                new Employee {EmployeeName="Dominic" ,HireDate=new DateTime(2022, 6, 27), Account="Dominic975036543@hmail.com",Password="098666432zxcvbn"},
                new Employee {EmployeeName="Eli" ,HireDate=new DateTime(2022, 6, 27), Account="Eli975036543@hmail.com",Password="098765432zxcvbn"},
                new Employee {EmployeeName="Floyd" ,HireDate=new DateTime(2022, 6, 27), Account="Floyd975036543@hmail.com",Password="098333432zxcvbn"},
                new Employee {EmployeeName="Gabriel" ,HireDate=new DateTime(2022, 6, 12), Account="Gabriel975036543@hmail.com",Password="098765333zxcvbn"},

                new Employee {EmployeeName="Hugo" ,HireDate=new DateTime(2022, 6, 27), Account="Hugo975036543@hmail.com",Password="098999432zxcvbn"},
                new Employee {EmployeeName="James" ,HireDate=new DateTime(2022, 6, 27), Account="James975036543@hmail.com",Password="098765432zxcvbn"},
                new Employee {EmployeeName="Karl" ,HireDate=new DateTime(2022, 5, 9), Account="Karl975036543@hmail.com",Password="118765432zxcvbn"},
                new Employee {EmployeeName="Matt" ,HireDate=new DateTime(2022, 3, 4), Account="Matt975036543@hmail.com",Password="094465432zxcvbn"},
                new Employee {EmployeeName="Mike" ,HireDate=new DateTime(2022, 6, 27), Account="Mike975036543@hmail.com",Password="098765400zxcvbn"},

            };
            foreach (var e in employees)
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
