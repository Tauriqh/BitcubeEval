using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using BitcubeEvalUsingIdentity.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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

        [BindProperty]
        public ApplicationUser AppUser { get; set; }

        [BindProperty]
        public string MessageSuccessDetails { get; set; }

        [BindProperty]
        public string ErrorMessageDetails { get; set; }

        [BindProperty]
        public string MessageSuccessPassword { get; set; }

        [BindProperty]
        public string ErrorMessagePassword { get; set; }

        [BindProperty]
        [Display(Name = "Current Password")]
        public string CurrentPassword { get; set; }

        [BindProperty]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        public async Task OnGetAsync()
        {
            if (AppUser == null)
            {
                AppUser = await _userManager.FindByNameAsync(_userManager.GetUserName(User));
            }

            Page();
        }

        public async Task<PageResult> OnPostDetailsAsync()
        {
            MessageSuccessDetails = "";

            if (AppUser == null)
            {
                AppUser = await _userManager.FindByNameAsync(_userManager.GetUserName(User));
            }

            if (!string.IsNullOrWhiteSpace(Request.Form["txtFirstName"]) && !string.IsNullOrWhiteSpace(Request.Form["txtLastName"]))
            {
                AppUser.FirstName = Request.Form["txtFirstName"];
                AppUser.LastName = Request.Form["txtLastName"];
                var result = await _userManager.UpdateAsync(AppUser);

                if(result.Succeeded)
                {
                    MessageSuccessDetails = "Successfully changed your details!!";
                }
                else
                {   
                    foreach (var error in result.Errors)
                    {
                        ErrorMessageDetails = error.Description;
                    }
                }
            }
            else
            {
                ErrorMessageDetails = "First Name or Last Name cannot be empty!!!";
            }

            return Page();
        }

        public async Task<PageResult> OnPostPasswordAsync()
        {
            MessageSuccessPassword = "";
            if (AppUser == null)
            {
                AppUser = await _userManager.FindByNameAsync(_userManager.GetUserName(User));
            }

            if (!string.IsNullOrWhiteSpace(Request.Form["txtCurrentPassword"]) && !string.IsNullOrWhiteSpace(Request.Form["txtNewPassword"]))
            {
                var result = await _userManager.ChangePasswordAsync(AppUser, Request.Form["txtCurrentPassword"], Request.Form["txtNewPassword"]);

                if (result.Succeeded)
                {
                    MessageSuccessPassword = "Successfully changed your password!!";
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ErrorMessagePassword = error.Description;
                    }
                }
            }
            else
            {
                ErrorMessagePassword = "Current Password or New Password cannot be empty!!!";
            }

            return Page();
        }
    }
}
