using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticalAssignment.Models;
using PracticalAssignment.Models.BusinessEntity;
using AutoMapper;
using PracticalAssignment.Models.DataEntity;
using Microsoft.AspNetCore.Identity;
using PracticalAssignment.Controllers;

namespace PracticalAssignment.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product,ProductVM>();
            CreateMap<ProductVM, Product>();
            CreateMap<Cart, CartVM>();
            CreateMap<IdentityUser, UserVM>();
            CreateMap<OrderDetail, OrderDetailVM>();
            CreateMap<Retailer, RetailerVM>();
            CreateMap<Customer, CustomerVM>();
            CreateMap<Order, OrderVM>();

        }
    }
}
