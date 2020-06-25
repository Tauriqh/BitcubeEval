using System.Threading.Tasks;
using BitcubeEvalUsingIdentity.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BitcubeEvalUsingIdentity.Areas.Identity.Pages.Account
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ProfileModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public ApplicationUser AppUser { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public async Task OnGetAsync()
        {
            AppUser = await _userManager.FindByNameAsync(_userManager.GetUserName(User));

            EmailAddress = AppUser.Email;
            FirstName = AppUser.FirstName;
            LastName = AppUser.LastName;
        }
    }
}
