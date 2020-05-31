using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticalAssignment.Data;
using PracticalAssignment.Models;
using PracticalAssignment.Models.BusinessEntity;
using PracticalAssignment.Models.DataEntity;
using AutoMapper.QueryableExtensions;

namespace PracticalAssignment.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IMapper _mapper;
        public ApplicationDbContext _context { get; }

        public AdminController(ApplicationDbContext context,
            UserManager<IdentityUser> userManager,
            IMapper mapper)
        {
            _context = context;
            _userManager = userManager;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<IdentityUser> DomainUsers = _userManager.Users.ToList();
            List<UserVM> UserVms = new List<UserVM>();
            foreach (var user in DomainUsers)
            {
                // Resolve the user via their email
                var userTemp = await _userManager.FindByEmailAsync(user.Email);

                // Get the roles for the user
                var roles = await _userManager.GetRolesAsync(userTemp);

                UserVM userVM = new UserVM()
                {
                    Id = user.Id,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    EmailConfirmation = user.EmailConfirmed 
                };
                UserVms.Add(userVM);
            }
            return View(UserVms);
        }


        [HttpGet]
        public async Task<IActionResult> EditStatus(string id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            UserVM userVM = _mapper.Map<IdentityUser, UserVM>(user);

            return View(userVM);
        }


        [HttpPost]
        public async Task<IActionResult> EditStatus(UserVM userVM)
        {
            var user = await _userManager.Users.Where(x => x.Id == userVM.Id).FirstOrDefaultAsync();
            user.EmailConfirmed = userVM.EmailConfirmation;
            _context.Update(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> RetailerProfile(int PageNumber = 1)
        {
            List<Retailer> DomainRetailers = await _context.Retailer.ToListAsync();
            List<RetailerVM> RetailesDTO = _mapper.Map<List<Retailer>, List<RetailerVM>>(DomainRetailers);
            return View(RetailesDTO);
        }

        [HttpGet]
        public IActionResult CustomerProfile()
        {
            List<Customer> DomainCustomer = _context.Customer.ToList();
            List<CustomerVM> CustomerDTO = _mapper.Map<List<Customer>, List<CustomerVM>>(DomainCustomer);
            return View(CustomerDTO);
        }

        [HttpGet]
        public IActionResult Order()
        {
            List<Order> order = _context.Order.Include("Customer").ToList();
            List<OrderVM> OrderDTO = _mapper.Map<List<Order>, List<OrderVM>>(order);
            return View(OrderDTO);
        }

        [HttpGet]
        public IActionResult OrderDetail()
        {
            List<OrderDetail> order = _context.OrderDetail.Include("Product").ToList();
            List<OrderDetailVM> OrderDTO = _mapper.Map<List<OrderDetail>, List<OrderDetailVM>>(order);
            return View(OrderDTO);
        }

    }
}