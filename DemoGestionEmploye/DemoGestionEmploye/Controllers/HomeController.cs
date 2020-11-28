using DemoGestionEmploye.Models;
using DemoGestionEmploye.ViewsModels;
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
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(1),
                TitrPage = "Détails employee"
            };

            return View(homeDetailsViewModel);
        }
    }
}
