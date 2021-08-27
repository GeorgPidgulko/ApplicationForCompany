using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_For_Infopulse.Shared.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long OrderId { get; set; }        
        public decimal TotalCost { get; set; }
        public long CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime DateOfOrder { get; set; }
        public ICollection<ProductInOrder> ProductsInOrder { get; set; }
        public string Comment { get; set; }

    }

    public enum OrderStatus
    {
        New,
        Paid,
        Shipped,
        Delivered,
        Closed
    }
}
