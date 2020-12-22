using System.ComponentModel.DataAnnotations;

namespace DemoGestionEmploye.ViewsModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
