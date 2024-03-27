using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    public class BranchSuppliers
    {
        public Branch Branch { get; set; }
        public Supplier Supplier  { get; set; }
        [ForeignKey("Branch")]
        public int Branch_Id { get; set; }
        [ForeignKey("Supplier")]
        public int Supplier_Id { get; set; }
    }
}
