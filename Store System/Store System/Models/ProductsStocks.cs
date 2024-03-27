using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    public class ProductsStocks
    {
        public Stock Stock { get; set; }
        public Product Product { get; set; }
        [ForeignKey("Product")]
        public int Product_Id { get; set; }
        [ForeignKey("Stock")]
        public int Stock_Id { get; set; }


        public int QuantityInStock { get; set; }
        public int MinQuantity { get; set; }
    }
}
