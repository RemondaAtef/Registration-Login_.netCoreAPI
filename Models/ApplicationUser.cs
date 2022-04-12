using Microsoft.AspNetCore.Identity;

namespace tagroba1000.API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        //public string Email { get; set; }
    }
}
