using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    public enum Role
    {
        Admin=0,
        Cashier=1,
    }

    public class User
    {
        

        [Key]
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }
        [RegularExpression("^01[0-9]{9}$")]
        [Phone(ErrorMessage ="رقم هاتف غير صالح يرجى ادخال الرقم مرة اخرى ")]
        public string? Phone { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public Role Role { get; set; }

        // Relationships 
        public virtual List<Order>? Orders { get; set; }
        public Branch Branch  { get; set; }
        [ForeignKey("Branch")]
        public int? Branch_Id { get; set; }
        public string MoneyStockName { get; set; }
        public double MoneyStockAmount { get; set; }




    }

}
