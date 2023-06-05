using Microsoft.AspNetCore.Identity;

namespace NetCore6_Auth.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string ? FirstName { get; set; }
        public string ? LastName { get; set; }
    }
}
