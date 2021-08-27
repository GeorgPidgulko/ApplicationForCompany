using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_For_Infopulse.Shared.Models
{
    public class ProductInOrder
    {
        public long Id { get; set; }
        public long ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }        
        public decimal ProductPrice { get; set; }        
    }
}
