using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suppliers.DataModel
{
    public class Product
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


        public Product()
        {
            DateAdded = DateTime.Now;
            DateModified = DateTime.Now;

        }

    }
}
