using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PracticalAssignment.Models;
using Microsoft.AspNetCore.Identity;

namespace PracticalAssignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public SignInManager<IdentityUser> SignInManager { get; }

        public HomeController(ILogger<HomeController> logger,
            SignInManager<IdentityUser> signInManager)
        {
            _logger = logger;
            SignInManager = signInManager;
        }

        public IActionResult Index()
        {
            if (SignInManager.IsSignedIn(User) && User.IsInRole("Customer"))
            {
                return RedirectToAction("Index", "Customer");
            }
            else if (SignInManager.IsSignedIn(User) && User.IsInRole("Admin"))
            {
                return RedirectToAction("Index", "Admin");
            }
            else if (SignInManager.IsSignedIn(User) && User.IsInRole("Retailer"))
            {
                return RedirectToAction("Index", "Retailer");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult RegistrationSuccess()
        {
            return View();
        }
    }
}
