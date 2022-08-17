using BSWebtoon.Admin.IDapperRepository;
using BSWebtoon.Model.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace BSWebtoon.Admin.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IDapperEmployeeRepository _employeeRepository;
        public EmployeeController(IDapperEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        public IActionResult management()
        {
            //R
            //var qAll = _employeeRepository.SelectAll();

            return View();
        }
    }
}
