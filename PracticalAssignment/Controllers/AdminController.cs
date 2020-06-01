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

    /// <summary>
    /// This Controller performs All Administrator tasks
    /// </summary>
    
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


        /// <summary>
        /// Shows Administrator all the Users
        /// </summary>
        /// <returns>AspNetUsers</returns>
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<IdentityUser> DomainUsers = await _userManager.Users.ToListAsync();
            List<UserVM> UserVms = new List<UserVM>();

            /*
                Assigining values of AspNetUsers
                to the DTO Model (UserVM)
             */
            foreach (var user in DomainUsers)
            {
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


        //Show Edit View for selected User
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

        /// <summary>
        /// Edits AspNetUser EmailConfirmation property
        /// </summary>
        /// <param name="userVM"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> EditStatus(UserVM userVM)
        {
            var user = await _userManager.Users.Where(x => x.Id == userVM.Id).FirstOrDefaultAsync();
            user.EmailConfirmed = userVM.EmailConfirmation;
            _context.Update(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        //This method gets all Retailers Profile
        [HttpGet]
        public async Task<IActionResult> RetailerProfile()
        {
            List<Retailer> DomainRetailers = await _context.Retailer.ToListAsync();

            //Mapping Object Using AutoMapper
            List<RetailerVM> RetailesDTO = _mapper.Map<List<Retailer>, List<RetailerVM>>(DomainRetailers);
            return View(RetailesDTO);
        }

        //This method gets all Customers Profile
        [HttpGet]
        public async Task<IActionResult> CustomerProfile()
        {
            List<Customer> DomainCustomer = await _context.Customer.ToListAsync();

            //Mapping Object Using AutoMapper
            List<CustomerVM> CustomerDTO = _mapper.Map<List<Customer>, List<CustomerVM>>(DomainCustomer);
            return View(CustomerDTO);
        }


        //This method gets all Orders
        [HttpGet]
        public async Task<IActionResult> Order()
        {
            List<Order> order = await _context.Order.Include("Customer").ToListAsync();

            //Mapping Object Using AutoMapper
            List<OrderVM> OrderDTO = _mapper.Map<List<Order>, List<OrderVM>>(order);
            return View(OrderDTO);
        }


        //This method gets all OrderDetails
        [HttpGet]
        public async Task<IActionResult> OrderDetail()
        {
            List<OrderDetail> order = await _context.OrderDetail.Include("Product").ToListAsync();

            //Mapping Object Using AutoMapper
            List<OrderDetailVM> OrderDTO = _mapper.Map<List<OrderDetail>, List<OrderDetailVM>>(order);
            return View(OrderDTO);
        }

    }
}