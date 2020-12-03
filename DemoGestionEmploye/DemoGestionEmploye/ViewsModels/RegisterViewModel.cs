using DemoGestionEmploye.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGestionEmploye.ViewsModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "L'email est requis")]
        [EmailAddress(ErrorMessage = "S'il vous plait entrer un mot de passe valide")]
        [Remote(action: "IsEmailInUse", controller:"account")]
        [ValidEmailDomain(allowedDomain: "mouhatech.com", 
            ErrorMessage = "Le domaine de l'email doit être mouhatech.com")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis")]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmer le mot de passe")]
        [Compare("Password",
            ErrorMessage = "Le mot de passe et le mot de passe de confirmation ne correspondent pas.")]
        public string ConfirmPassword { get; set; }
    }
}
