using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_For_Infopulse.Shared.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ProductId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public ProductCategory Category { get; set; }
        public ICollection<ProductInOrder> productInOrders { get; set; }
        public Size ProductSize { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }

    public enum ProductCategory
    {
        Foods,
        Electronics,
        Stationery,
        Goods
    }

    public enum Size
    {
        Large,
        Medium,
        Small,
        NotIndicated
    }
}
