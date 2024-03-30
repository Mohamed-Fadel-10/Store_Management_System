using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Data
{
    public class BindingOrdersAndItems
    {
        public string BranchName { get; set; }
        public string Address { get; set; }
        public string BranchPhone { get; set; }

        public int Order_ID { get; set; }
        public string BillType { get; set; }
        public DateTime Date { get; set; }
        public double OrderTotalPrice { get; set; }
        public double Discount { get; set; }

        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }

        public string Barcode { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double ProductTotal { get; set; }

        public int TotalQuantity { get; set; }
        public double AfterDiscount { get; set; }
        public double Paid { get; set; }
        public double Remaining { get ; set; }

        public int Count { get; set; }

    }
}
