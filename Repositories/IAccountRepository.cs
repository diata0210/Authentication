using Microsoft.AspNetCore.Identity;
using NetCore6_Auth.Models;

namespace NetCore6_Auth.Repositories
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> SignUpAsync(SignUpModel model);
        public Task<string> SignInAsync(SignInModel model);
    }
}
