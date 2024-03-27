using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    internal class Supplier
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public DateTime?  ContractDate { get; set; }
        /// Relations
        public List<ProductsSuppliers> ProductsSuppliers { get; set; }
        public List<BranchSuppliers> branchSuppliers { get; set; }


    }
}
