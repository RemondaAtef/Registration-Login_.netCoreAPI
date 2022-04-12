using tagroba1000.API.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace tagroba1000.API.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(SignInModel signInModel);
    }
}
