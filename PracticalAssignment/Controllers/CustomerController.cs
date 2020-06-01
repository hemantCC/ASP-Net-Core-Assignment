using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using PracticalAssignment.Data;
using PracticalAssignment.Models;
using PracticalAssignment.Models.BusinessEntity;
using PracticalAssignment.Models.DataEntity;


namespace PracticalAssignment.Controllers
{
    /// <summary>
    /// This Controller performs All Customer tasks
    /// </summary>

    [Authorize(Roles = "Customer")]
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        List<OrderDetailVM> cart = new List<OrderDetailVM>();

        public IMemoryCache MemoryCache { get; }

        public CustomerController(ApplicationDbContext context,
            IMapper mapper,
            IMemoryCache memoryCache)
        {
            _context = context;
            _mapper = mapper;
            MemoryCache = memoryCache;
        }

        
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //Caching
            List<Product> product;
            if (!MemoryCache.TryGetValue("Products", out product))
            {
                if (product == null)
                { 
                    product = await _context.Product.ToListAsync();
                }
                MemoryCache.Set("Product",product);
            }

            //Mapping into DTO
            List<ProductVM> productVMs = _mapper.Map<List<Product>, List<ProductVM>>(product);
            return View(productVMs);
        }


        /// <summary>
        /// POST : Single Orders into Order and OrderDetail 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Quantity"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task<IActionResult> BuySingleProduct(int id, int Quantity)
        {
            //Add Order to database
            Product product = _context.Product.Find(id);

            //Assign OrderDetail values 
            OrderDetail Order = new OrderDetail()
            {
                Category = product.Category,
                Product = product,
                Quantity = Quantity,
                Unit = product.Unit,
                Price = product.UnitPrice,
                Discount = product.ApplicableDiscount * Quantity, // calculate total discount and store
                Total = (product.UnitPrice * Quantity) - (product.ApplicableDiscount * Quantity), // calculate sub total and store
                CustomerId = CurrentCustomerId() // Assigns Current User ID

            };

            //Assign Order Values
            Customer customer = await _context.Customer.Where(x => x.Id == CurrentCustomerId()).FirstOrDefaultAsync();
            Random random = new Random();
            int orderNumber = random.Next(10000000);
            Order FinalOrder = new Order()
            {
                OrderNumber = orderNumber,
                OrderDate = DateTime.Now.Date,
                Customer = customer,
                TotalDiscount = Order.Discount,
                TotalAmount = Order.Total,
                OrderStatus = "Received"

            };

            await _context.OrderDetail.AddAsync(Order);
            await _context.Order.AddAsync(FinalOrder);
            await _context.SaveChangesAsync();
            TempData["OrderPlaced"] = "success";
            return RedirectToAction("CustomerWiseOrder");
        }


        /// <summary>
        /// Adds Single Product To Cart
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Quantity"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddToCart(int id, int Quantity)
        {
            List<Cart> cartItems = _context.Cart.Include("Product").ToList();
            foreach (var item in cartItems)
            {
                if (item.Product.ProductId == id)
                {
                    TempData["AlreadyExists"] = "success";
                    return RedirectToAction("Index");
                }
            }
            Product product = _context.Product.Find(id);
            Cart CartProduct = new Cart()
            {
                Category = product.Category,
                Product = product,
                Quantity = Quantity,
                Unit = product.Unit,
                Price = product.UnitPrice,
                Discount = product.ApplicableDiscount * Quantity,
                Total = (product.UnitPrice * Quantity) - (product.ApplicableDiscount * Quantity),
                CustomerId = CurrentCustomerId()
            };

            await _context.Cart.AddAsync(CartProduct);
            await _context.SaveChangesAsync();
            TempData["AddToCart"] = "success";
            return RedirectToAction("Index");
        }


        //Gets Cart Items
        [HttpGet]
        public async Task<IActionResult> Cart()
        {
            List<Cart> CartItems = await _context.Cart.Include("Product").ToListAsync();

            //Mapping to DTO
            List<CartVM> CartItemsVM = _mapper.Map<List<Cart>, List<CartVM>>(CartItems);
            return View(CartItemsVM);
        }

        //Adds all CartItems to Order and OrderDetail
        [HttpGet]
        public async Task<IActionResult> ConfirmOrder()
        {
            List<Cart> cartItems = await _context.Cart.Where(x => x.CustomerId == CurrentCustomerId()).Include("Product")
                .ToListAsync();

            if (cartItems.Count == 0)
            {
                TempData["EmptyCart"] = "success";
                return RedirectToAction("Cart");
            }

            //ForAdding OrderDetail
            foreach (var item in cartItems)
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    Category = item.Category,
                    Product = item.Product,
                    Quantity = item.Quantity,
                    Unit = item.Unit,
                    Price = item.Price,
                    Discount = item.Discount,
                    Total = item.Total,
                    CustomerId = item.CustomerId
                };
                _context.OrderDetail.Add(orderDetail);
            }

            //For Adding Order
            int totalDiscount = 0, totalAmount = 0;
            foreach (var item in cartItems)
            {
                totalDiscount = totalDiscount + item.Discount;
                totalAmount = totalAmount + item.Total;
            }
            Customer customer = _context.Customer.Where(x => x.Id == CurrentCustomerId()).FirstOrDefault();
            Random random = new Random();
            int orderNumber = random.Next(10000000);
            Order order = new Order()
            {
                OrderNumber = orderNumber,
                OrderDate = DateTime.Now.Date,
                Customer = customer,
                TotalDiscount = totalDiscount,
                TotalAmount = totalAmount,
                OrderStatus = "Received"

            };
            _context.Order.Add(order);

            //Deleting Orders from Cart for Particular User
            foreach (var item in cartItems)
            {
                _context.Cart.Remove(item);
            }

            _context.SaveChanges();
            TempData["OrderPlaced"] = "success";
            return RedirectToAction("CustomerWiseOrder");
        }

        //Shows OrderDeails of Respective Customer
        [HttpGet]
        public async Task<IActionResult> CustomerWiseOrder()
        {
            IEnumerable<OrderDetail> order = await _context.OrderDetail.Where(x => x.CustomerId == CurrentCustomerId())
                .Include("Product").ToListAsync();

            //Mapping to DTO
            IEnumerable<OrderDetailVM> orderDTO =
                _mapper.Map<IEnumerable<OrderDetail>, IEnumerable<OrderDetailVM>>(order);
            return View(orderDTO);
        }

        //Removes Cart Items
        [HttpGet]
        public async Task<IActionResult> RemoveCartItem(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Cart cart = await _context.Cart.Where(x => x.CartId == id).FirstOrDefaultAsync();
            if (cart == null)
            {
                return NotFound();
            }
            _context.Remove(cart);
            await _context.SaveChangesAsync();
            return RedirectToAction("Cart");
        }


        //Deletes All Cart items for Respective Customer 
        public async Task<IActionResult> EmptyCart()
        {
            List<Cart> cart = await _context.Cart.Where(x => x.CustomerId == CurrentCustomerId()).ToListAsync();
            if (cart.Count == 0)
            {
                TempData["AlreadyEmpty"] = "success";
            }
            if (cart == null)
            {
                return NotFound();
            }
            _context.RemoveRange(cart);
            _context.SaveChanges();
            return RedirectToAction("Cart");
        }


        //Returns Customer Id of Current User
        public int CurrentCustomerId()
        {
            var CustomerEmail = User.FindFirstValue(ClaimTypes.Name);
            int customerId = _context.Customer.Where(x => x.Email == CustomerEmail).Select(x => x.Id).FirstOrDefault();
            return customerId;
        }


    }
}