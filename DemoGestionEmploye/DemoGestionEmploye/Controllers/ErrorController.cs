using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoGestionEmploye.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Désolé, la ressource demandée est introuvable";
                    break;
            }
            return View("NotFound");
        }
    }
}
