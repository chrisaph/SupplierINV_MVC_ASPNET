using Suppliers.DataModel;
using System.ComponentModel.DataAnnotations;

namespace SuppliersINV.App.Models
{
    public class SignInVM
    {
        public SignInVM() 
        {
            Username = "";
            Password = "";
            ReturnUrl = "";
        }

        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }

    }
}
