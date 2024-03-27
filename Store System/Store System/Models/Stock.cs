using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    public class Stock
    {
        [Key]
        public int ID { get; set; }

        public string? Name { get; set; }
        public string? StockManager { get; set; }
        public List<ProductsStocks> ProductsStocks { get; set; }


    }
}
