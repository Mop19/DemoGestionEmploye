﻿using System.ComponentModel.DataAnnotations;

namespace DemoGestionEmploye.Models
{
    public class Employee
    {
        public int Id { get; set; }
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
        public string PhotoPath { get; set; }
    }
}
