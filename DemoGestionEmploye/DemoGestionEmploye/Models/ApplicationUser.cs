using Microsoft.AspNetCore.Identity;

namespace DemoGestionEmploye.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string City { get; set; }
    }
}
