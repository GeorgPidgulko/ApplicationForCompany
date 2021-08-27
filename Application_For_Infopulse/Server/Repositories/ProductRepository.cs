using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application_For_Infopulse.Shared.Models;
using Application_For_Infopulse.Server.Repositories.InterFaces;
using Application_For_Infopulse.Server.Data;

namespace Application_For_Infopulse.Server.Repositories
{
    //public class ProductRepository : IRepository<Product>
    //{
    //    private readonly ApplicationDbContext _context;
    //    List<Product> products;
    //    public ProductRepository(ApplicationDbContext context)
    //    {
    //        products = new List<Product>
    //        {
    //            new Product { Id=1, ProductNumber="#11", Category=ProductCategory.Foods, Name="Pizza", ProductSize=Size.Large, Price=50, Quantity= 10, Description="Very Good" },
    //            new Product { Id=2, ProductNumber="#22", Category=ProductCategory.Foods, Name="Pizza_sm", ProductSize=Size.Small, Price=40, Quantity= 10, Description="Very Good" },
    //            new Product { Id=3, ProductNumber="#33", Category=ProductCategory.Foods, Name="Pizza_md", ProductSize=Size.Medium, Price=60, Quantity= 10, Description="Very Good" },
    //            new Product { Id=4, ProductNumber="#44", Category=ProductCategory.Goods, Name="Umbrella", ProductSize=Size.NotIndicated, Price=200, Quantity= 15, Description="Perfect" },
    //            new Product { Id=5, ProductNumber="#55", Category=ProductCategory.Electronics, Name="Iphone", ProductSize=Size.NotIndicated, Price=1000, Quantity= 5, Description="New model" },
    //        };
    //    }
    //    public void Create(Product item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Product Get(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public List<Product> GetAll()
    //    {
    //         return products.ToList();
    //    }

    //    public IEnumerable<Product> GetAllAsync(Func<Product, bool> predicate)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update(Product item)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
