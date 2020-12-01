using DemoGestionEmploye.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoGestionEmploye.ViewsModels
{
    public class EmployeeCreateViewModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Le nom ne doit pas dépasser 50 caractères")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
            ErrorMessage = "Format de l'éamil n'est pas valide")]
        [Display(Name = "Office email")]
        public string Email { get; set; }
        [Required]
        public Dept? Departement { get; set; }
        public List<IFormFile> Photos { get; set; }
    }
}
