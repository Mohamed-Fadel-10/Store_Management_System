using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    internal class Order
    {
        [Key]
        public int ID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string? CustomerName { get; set; }
        public  bool IsSale { get; set; } //  0 for sale , 1 for buy
       
        /// one user to many Pills
        public virtual User user { get; set; }
        [ForeignKey("user")]
        public int? user_id { get; set; }
        public virtual List<OrderItems>? OrderItems { get; set; }
        public virtual Customer Customer { get; set; }
        [ForeignKey("Customer")]
        public int? Customer_Id { get; set; }

        public virtual List<Returned>? Returneds { get; set; }

    }
}
