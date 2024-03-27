using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    internal class ReturnedItems
    {
        public Returned Returned { get; set; }
        public Product Product { get; set; }
        [ForeignKey("Returned")]
        public int Returned_Id { get; set; }
        [ForeignKey("Product")]
        public int Product_Id { get; set; }
        public string? Notes { get; set; } // سبب الارجاع
        public int? OrderID { get; set; }
        public int? ReturnedQuantity { get; set; }





    }
}
