using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public virtual List<Product>? Products { get; set; }
    }
}
