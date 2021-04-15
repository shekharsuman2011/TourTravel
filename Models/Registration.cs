using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrialTours.Models
{
    public class Registration
    {
        [Key]
        public int UserId { get; set; }


        [Required(ErrorMessage ="Please Enter Your Name")]
        [StringLength(50)]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please Enter Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please Enter Your Contact Number..")]
        [Display(Name = "Phone Number")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Enter a valid phone number")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Please Enter Password..")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Please Confirm Your Password...")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}