using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    public class ProductsSuppliers
    {
        public virtual Supplier Supplier { get; set; }
        public virtual Product Product  { get; set; }
        [ForeignKey("Product")]
        public int? product_Id { get; set; }
        [ForeignKey("Supplier")]
        public int? Supplier_Id { get; set; }
    }
}
