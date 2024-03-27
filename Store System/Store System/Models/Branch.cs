using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    public class Branch
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? ManagerName { get; set; }
        public string? Description { get; set; }
        public string?  Address  { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public double MainMoneyStock { get; set; }
        public virtual List<User> Users  { get; set; }
        public List<BranchSuppliers> branchSuppliers { get; set; }
        public  virtual List<Employee> Employees { get; set; }


    }
}
