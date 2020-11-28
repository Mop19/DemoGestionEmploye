using DemoGestionEmploye.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoGestionEmploye.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }

        public ViewResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            ViewData["Employee"] = model;
            ViewData["TitrePage"] = "Détails employee";
            return View();
        }
    }
}
