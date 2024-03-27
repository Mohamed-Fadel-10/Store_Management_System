using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    public class Returned
    {
        public int id { get; set; }
        public DateTime Date { get; set; }
        public List<ReturnedItems> ReturnedItems { get; set; }

    }
}
