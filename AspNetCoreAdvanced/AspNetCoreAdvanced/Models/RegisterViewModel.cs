using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreAdvanced.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        //[Remote(action:"IsEmailInUse", controller:"account")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Passwords does not match")]
        public string ConfirmPassword { get; set; }
    }
}
