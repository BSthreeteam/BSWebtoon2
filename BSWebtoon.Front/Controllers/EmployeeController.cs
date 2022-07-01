using BSWebtoon.Front.Service.EmployeeService;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BSWebtoon.Front.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly IEmployeeService _Employeeservice;
        private readonly BSRepository _repository;
        public EmployeeController(BSRepository repository, IEmployeeService EmployeeService)
        {
            _Employeeservice = EmployeeService;
            _repository = repository;
        }
        public IActionResult AddEmployeeView() //Employee/AddEmployeeView
        {
            _Employeeservice.EmployeeCreate();
            return View();
        }
    }
}
