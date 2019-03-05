//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cart.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Customer
    {
        public int CId { get; set; }
        [Required(ErrorMessage ="This feild is required.")]
        public string Name { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "This feild is required.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This feild is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]

        [DisplayName("Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public bool IsAdmin { get; set; }
    }
}
