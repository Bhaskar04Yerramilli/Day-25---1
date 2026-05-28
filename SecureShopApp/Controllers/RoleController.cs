using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace SecureShopApp.Controllers
{
    public class RoleController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public RoleController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MakeAdmin()
        {
            var user = await _userManager.FindByEmailAsync("test@gmail.com");

            if (user != null)
            {
                await _userManager.AddToRoleAsync(user, "Admin");
            }

            return Content("User assigned to Admin role");
        }
    }
}
