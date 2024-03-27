using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Data
{
    public class BindingOrdersAndItems
    {
        public string Barcode { get; set; }
        public int Order_ID { get; set; }
        public double TotalPrice { get; set; }
        public int Count { get; set; }
        public double Discount { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }

    }
}
