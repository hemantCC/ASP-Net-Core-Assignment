using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NETCore.MailKit.Core;
using PracticalAssignment.Data;
using PracticalAssignment.Models;
using PracticalAssignment.Models.BusinessEntity;
using PracticalAssignment.Models.DataEntity;

namespace PracticalAssignment.Controllers
{

    [Authorize(Roles = "Retailer")]
    public class RetailerController : Controller
    {

        private readonly ApplicationDbContext _context;
        public IWebHostEnvironment _hostEnvironment { get; }
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IMapper _mapper;
        private RoleManager<IdentityRole> _roleManager { get; }
        public IEmailService EmailSender { get; }

        public RetailerController(
            ApplicationDbContext context,
            IWebHostEnvironment hostEnvironment,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            RoleManager<IdentityRole> roleManager,
            IMapper mapper,
            IEmailService EmailSender)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _roleManager = roleManager;
            _mapper = mapper;
            this.EmailSender = EmailSender;
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RetailerVM retailerVM)
        {
            var role = _roleManager.FindByNameAsync("Retailer").Result;
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = retailerVM.PersonalEmail,
                    Email = retailerVM.PersonalEmail,
                    PhoneNumber = retailerVM.ContactNumber,
                };
                Retailer DomainRetailer = new Retailer
                {
                    Id = retailerVM.Id,
                    Name = retailerVM.Name,
                    ContactNumber = retailerVM.ContactNumber,
                    PersonalEmail = retailerVM.PersonalEmail,
                    BusinessEmail = retailerVM.BusinessEmail,
                    Address1 = retailerVM.Address1,
                    Address2 = retailerVM.Address2,
                    City = retailerVM.City,
                    State = retailerVM.State,
                    Zipcode = retailerVM.Zipcode
                };
                var result = await _userManager.CreateAsync(user, retailerVM.Password);
                if (result.Succeeded)
                {
                    _context.Retailer.Add(DomainRetailer);
                    _context.SaveChanges();

                    var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var confirmationLink = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = token }, Request.Scheme);

                    _logger.LogInformation("User created a new account with password.");

                    await EmailSender.SendAsync(retailerVM.PersonalEmail, "Confirm your email",
                     $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(confirmationLink)}'>clicking here</a>.", true);

                    //Populates Roles if Not available
                    await PopulateRoles();

                    await _userManager.AddToRoleAsync(user, role.Name);

                    //await _signInManager.SignInAsync(user, isPersistent: false);
                    TempData["successLogin"] = "success";
                    return RedirectToAction("RegistrationSuccess", "Account");

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return View();
        }

        public IActionResult Index()
        {
            var email = User.FindFirstValue(ClaimTypes.Name);
            int id = _context.Retailer.Where(x => x.PersonalEmail == email).Select(x => x.Id).FirstOrDefault();

            List<Product> product = _context.Product.Where(x => x.ProductRetailer == id.ToString()).ToList();
            List<ProductVM> productVMs = _mapper.Map<List<Product>, List<ProductVM>>(product);
            return View(productVMs);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductVM productVM)
        {
            if (ModelState.IsValid)
            {
                //Saves image to wwwroot/image
                string WwwRootPath = _hostEnvironment.WebRootPath;
                string FileName = Path.GetFileNameWithoutExtension(productVM.ImageFile.FileName);
                string Extension = Path.GetExtension(productVM.ImageFile.FileName);
                productVM.Photo = FileName = FileName + DateTime.Now.ToString("yymmssyyyy") + Extension;
                string path = Path.Combine(WwwRootPath + "/image/" + FileName);
                using (var FileStream = new FileStream(path, FileMode.Create))
                {
                    await productVM.ImageFile.CopyToAsync(FileStream);
                }

                Product product = _mapper.Map<ProductVM, Product>(productVM);

                product.ProductRetailer = GetCurrentRetailerId();

                //Insert record
                await _context.Product.AddAsync(product);
                await _context.SaveChangesAsync();
                TempData["ProductAdded"] = "success";
                return RedirectToAction("Index");
            }
            return View(productVM);
        }


        [HttpGet]
        public async Task<IActionResult> OrdersForRetailer()
        {
            List<OrderDetail> orderDetails = await _context.OrderDetail.Where(x => x.Product.ProductRetailer == GetCurrentRetailerId()).Include("Product")
                .ToListAsync();

            List<OrderDetailVM> orderDetailVM = _mapper.Map<List<OrderDetail>, List<OrderDetailVM>>(orderDetails);

            return View(orderDetailVM);
        }

        public async Task<IActionResult> EditProduct(int id)
        {
            Product product = await _context.Product.FindAsync(id);
            ProductVM productDTO = _mapper.Map<Product, ProductVM>(product);
            return View(productDTO);
        }

        [HttpPost]
        public async Task<IActionResult> EditProduct(int id, ProductVM productVM)
        {
            Product product = _mapper.Map<ProductVM, Product>(productVM);

            Product OriginalProduct = _context.Product.AsNoTracking().Where(x => x.ProductId == id)
                    .FirstOrDefault();
            product.ProductRetailer = OriginalProduct.ProductRetailer;
            product.ProductId = id;

            if (!ModelState.IsValid)
            {
                return View(productVM);
            }
            if (productVM.ImageFile == null)
            {
                product.Photo = OriginalProduct.Photo;
            }
            else
            {
                //Updates image to wwwroot/image
                string WwwRootPath = _hostEnvironment.WebRootPath;
                string FileName = Path.GetFileNameWithoutExtension(productVM.ImageFile.FileName);
                string Extension = Path.GetExtension(productVM.ImageFile.FileName);
                product.Photo = FileName = FileName + DateTime.Now.ToString("yymmssyyyy") + Extension;
                string path = Path.Combine(WwwRootPath + "/image/" + FileName);
                using (var FileStream = new FileStream(path, FileMode.Create))
                {
                    await productVM.ImageFile.CopyToAsync(FileStream);
                }
            }

            _context.Update(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<bool> PopulateRoles()
        {
            //Populat Roles in Database at the Initial  
            if (!await _roleManager.RoleExistsAsync("Customer"))
            {
                await _roleManager.CreateAsync(new IdentityRole("Customer"));
            }
            if (!await _roleManager.RoleExistsAsync("Retailer"))
            {
                await _roleManager.CreateAsync(new IdentityRole("Retailer"));
            }
            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole("Admin"));
            }
            return true;

        }

        public string GetCurrentRetailerId()
        {
            var email = User.FindFirstValue(ClaimTypes.Name);
            int id = _context.Retailer.Where(x => x.PersonalEmail == email).Select(x => x.Id).FirstOrDefault();
            return id.ToString();
        }


    }
}