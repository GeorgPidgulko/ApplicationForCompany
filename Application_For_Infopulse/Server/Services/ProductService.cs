using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application_For_Infopulse.Server.Data;
using Application_For_Infopulse.Server.Repositories;
using Application_For_Infopulse.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Application_For_Infopulse.Server.Services
{
    public class ProductService
    {
        private readonly UnitOfWork _db;
        public ProductService(UnitOfWork db)
        {
            _db = db;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _db.Products.GetAll().ToListAsync();
        }

        public async Task CreateProductAsync(Product product)
        {
            _db.Products.Create(product);
            await _db.SaveAsync();
        }

        public async Task DeleteProductAsync(long productId)
        {
            _db.Products.Delete(productId);
            await _db.SaveAsync();
        }
    }
}
