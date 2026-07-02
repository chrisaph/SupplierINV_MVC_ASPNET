using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SuppliersINV.App.Models
{
    public class RegisterVM
    {
        public RegisterVM()
        {
            
            Email = "";
            Password = "";
            ConfirmPassword = "";
        }
       
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Confirm Password")]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
