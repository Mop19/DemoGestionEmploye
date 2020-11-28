using DemoGestionEmploye.Models;
using DemoGestionEmploye.ViewsModels;
using Microsoft.AspNetCore.Mvc;

namespace DemoGestionEmploye.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [Route("")]     
        [Route("~/")]
        [Route("~/Home")]
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }

        [Route("{id?}")]
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id??1),
                TitrPage = "Détails employee"
            };

            return View(homeDetailsViewModel);
        }
    }
}
