﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using NETCore.MailKit.Core;
using PracticalAssignment.Data;
using PracticalAssignment.Models;
using PracticalAssignment.Models.DataEntity;

namespace PracticalAssignment.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context,
            IEmailService EmailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            RoleManager = roleManager;
            Context = context;
            this.EmailSender = EmailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }
        public RoleManager<IdentityRole> RoleManager { get; }
        public ApplicationDbContext Context { get; }
        public IEmailService EmailSender { get; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            //Custome Properties
            [Required]
            public string Name { get; set; }

            [Required]
            [Phone]
            public string PhoneNumber { get; set; }

            [Required]
            public string Address1 { get; set; }
            public string Address2 { get; set; }

            [Required]
            public string City { get; set; }

            [Required]
            public string State { get; set; }

            [Required]
            public string Zipcode { get; set; }

        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            
            if (ModelState.IsValid)
            {
               
                var user = new IdentityUser
                {
                    UserName = Input.Email,
                    Email = Input.Email,
                    PhoneNumber = Input.PhoneNumber
                };
                Customer DomainCustomer = new Customer 
                {
                    Name = Input.Name,
                    Email = Input.Email,
                    ContactNumber = Input.PhoneNumber,
                    Address1 = Input.Address1,
                    Address2 = Input.Address2,
                    City = Input.City,
                    State = Input.State,
                    Zipcode = Input.Zipcode
                };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    Context.Customer.Add(DomainCustomer);
                    Context.SaveChanges();

                    var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var confirmationLink = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = token }, Request.Scheme);

                    _logger.LogInformation("User created a new account with password.");

                    await EmailSender.SendAsync(Input.Email, "Confirm your email",
                     $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(confirmationLink)}'>clicking here</a>.",true);

                    //Populates Roles if Not available
                    await PopulateRoles();

                    var role = RoleManager.FindByNameAsync("Customer").Result;
                    await _userManager.AddToRoleAsync(user, role.Name);

                    TempData["successLogin"] = "success";

                    return RedirectToAction("RegistrationSuccess","Account");

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        //Populate Roles in Database at the Initial 
        public async Task<bool> PopulateRoles()
        {
             
            if (!await RoleManager.RoleExistsAsync("Customer"))
            {
                await RoleManager.CreateAsync(new IdentityRole("Customer"));
            }
            if (!await RoleManager.RoleExistsAsync("Retailer"))
            {
                await RoleManager.CreateAsync(new IdentityRole("Retailer"));
            }
            if (!await RoleManager.RoleExistsAsync("Admin"))
            {
                await RoleManager.CreateAsync(new IdentityRole("Admin"));
            }
            return true;

        }

    }
}
