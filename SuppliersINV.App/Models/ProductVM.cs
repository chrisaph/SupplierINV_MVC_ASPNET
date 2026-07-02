using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SuppliersINV.App.Models
{
    public class ProductVM
    {
        public int ProductID { get; set; }
        [DisplayName("Name")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Description")]
        [Required]
        public string Description { get; set; }
        [DisplayName("Quantity")]
        [Required]
        public int Qty { get; set; }
        [DisplayName("Unit")]
        [Required]
        public string Unit { get; set; }
        [DisplayName("Date Added")]
        [Required]
        public DateTime DateAdded { get; set; }
        [DisplayName("Date Modified")]
        public DateTime? DateModified { get; set; }


        public ProductVM()
        {
            DateAdded = DateTime.Now;
            DateModified = DateTime.Now;
        }
    }
}
