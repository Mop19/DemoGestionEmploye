using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGestionEmploye.Controllers
{
    public class DepartementsController
    {
        public string List()
        {
            return "Liste des départements";
        }

        public string Details()
        {
            return "Details() du Departement";
        }
    }
}
