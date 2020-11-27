using DemoGestionEmploye.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoGestionEmploye.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }
    }
}
