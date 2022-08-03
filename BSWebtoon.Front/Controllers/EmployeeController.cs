using BSWebtoon.Front.Service.EmployeeService;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly IEmployeeService _Employeeservice;
        public EmployeeController( IEmployeeService EmployeeService)
        {
            _Employeeservice = EmployeeService;
        }
        public IActionResult AddEmployeeView() //Employee/AddEmployeeView
        {
            //_Employeeservice.EmployeeCreate();
            return View();
        }
    }
}
