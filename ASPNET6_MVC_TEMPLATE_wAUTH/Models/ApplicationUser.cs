using Microsoft.AspNetCore.Identity;

namespace ASPNET6_MVC_TEMPLATE_wAUTH.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
