using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PracticalAssignment.Controllers
{
    public class AccountController : Controller
    {
        public AccountController(UserManager<IdentityUser> userManager)
        {
            UserManager = userManager;
        }

        public UserManager<IdentityUser> UserManager { get; }

        public async Task<IActionResult> ConfirmEmail(string UserId, string Token)
        {
            var user = await UserManager.FindByIdAsync(UserId);
            if (user == null)
            {
                return BadRequest();
            }
            var result = await UserManager.ConfirmEmailAsync(user , Token);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Home");
            }
            return View();
        } 

        public IActionResult RegistrationSuccess()
        {
            return View();
        }
    }
}