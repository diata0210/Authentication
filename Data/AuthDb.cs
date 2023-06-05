using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NetCore6_Auth.Data
{
    public class AuthDb : IdentityDbContext<ApplicationUser>
    {
        public AuthDb(DbContextOptions<AuthDb> options) : base(options)
        {
        }
    }
}
