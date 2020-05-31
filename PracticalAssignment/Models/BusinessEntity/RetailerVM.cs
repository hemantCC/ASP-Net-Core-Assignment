using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalAssignment.Models.BusinessEntity
{
    public class RetailerVM
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Personal Email")]
        public string PersonalEmail { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        //Customer Properties
        [Required]
        public string Name { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Contact")]
        public string ContactNumber { get; set; }

        [Required]
        [Display(Name = "Business Address Line 1")]
        public string Address1 { get; set; }
        [Display(Name = "Business Address Line 1")]
        public string Address2 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Zipcode { get; set; }


        [EmailAddress]
        [Display(Name = "Business Email")]
        public string BusinessEmail { get; set; }
    }
}
