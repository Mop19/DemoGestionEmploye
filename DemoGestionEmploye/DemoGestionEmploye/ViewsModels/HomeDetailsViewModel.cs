using DemoGestionEmploye.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGestionEmploye.ViewsModels
{
    public class HomeDetailsViewModel
    {
        public Employee Employee { get; set; }
        public string TitrPage { get; set; }
    }
}
