using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    internal class OrderItems
    {


        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
        //[Column("ProductID")] 

        [ForeignKey("Product")]
        public int product_Id { get; set; }
       // [Column("OrderID")]  

        [ForeignKey("Order")]

        public int Order_Id { get; set; }
        public double TotalPrice { get; set; }
        public double Discount { get; set; }
        public int Quantity { get; set; }
        public string? Size  { get; set; }
        public string? Color { get; set; }
        public string? Description { get; set; }




    }
}
