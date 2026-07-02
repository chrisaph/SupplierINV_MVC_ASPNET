using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suppliers.DataModel
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        [DisplayName("Company Name")]
        [Required]
        public string CompanyName { get; set; }
        [DisplayName("Address")]
        [Required]
        public string Address { get; set; }
        [DisplayName("Representative")]
        [Required]
        public string Representative { get; set; }
        [DisplayName("Contact No.")]
        [Required]
        public string ContactNo { get; set; }
        [DisplayName("Date Added")]
        [Required]
        public DateTime DateAdded { get; set; }
        [DisplayName("Date Modified")]
        public DateTime? DateModified { get; set; }


        public Supplier()
        {
            DateAdded = DateTime.Now;
            DateModified = DateTime.Now;

        }

        //        SupplierID Int – Primary key
        //CompanyName Nvarchar(MAX)
        //Address Nvarchar(MAX)
        //Representative Nvarchar(MAX)
        //ContactNo Nvarchar(MAX)
        //DateAdded DateTime2(7)
        //DateModified DateTime2(7) (Nullable Type)
    }
}
