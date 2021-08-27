using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_For_Infopulse.Shared.Models
{
    public class Customer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public ICollection<Order> Orders { get; set; }
        public string Address { get; set; }
        [NotMapped]
        public decimal TotalOrderCost { get; set; }
        [NotMapped]
        public int OrdersCount { get; set; }
    }
}
