using Application_For_Infopulse.Server.Repositories;
using Application_For_Infopulse.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using Application_For_Infopulse.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace Application_For_Infopulse.Server.Services
{
    public class OrderService
    {
        private readonly UnitOfWork _db;
        public OrderService(UnitOfWork db)
        {
            _db = db;
        }

        public async Task<List<Order>> GetAllAsync()
        {
            return await _db.Orders.GetAll()
                .Include(a=>a.Customer)
                .ToListAsync();          
        }

        public async Task<Order> GetAsync(long orderId)
        {
            return await _db.Orders.GetAll()
                .Include(a => a.Customer)
                .Include(a => a.ProductsInOrder).ThenInclude(a => a.Product)
                .FirstOrDefaultAsync(a => a.OrderId == orderId);
        }

        public async Task CreateOrderAsync(Order order)
        {
            foreach (var productInOrder in order.ProductsInOrder)
            {
                Product product = _db.Products.Get(productInOrder.Product.ProductId);
                product.Quantity -= productInOrder.Quantity;
                _db.Products.Update(product);
                productInOrder.ProductId = productInOrder.Product.ProductId;
                productInOrder.Product = null;
            }

            _db.Orders.Create(order);
            await _db.SaveAsync();
        }  
        
        public async Task UpdateOrderAsync(Order order)
        {
            Order oldOrder = await _db.Orders.GetAll().AsNoTracking().Include(a => a.ProductsInOrder).FirstOrDefaultAsync(a=>a.OrderId == order.OrderId);

            foreach (var productInOrder in order.ProductsInOrder)
            {
                if (oldOrder.ProductsInOrder.FirstOrDefault(a => a.ProductId == productInOrder.ProductId) == null)
                {
                    Product product = _db.Products.Get(productInOrder.Product.ProductId);
                    product.Quantity -= productInOrder.Quantity;
                    _db.Products.Update(product);
                    productInOrder.ProductId = productInOrder.Product.ProductId;
                    productInOrder.Product = null;
                }
            }

            _db.Orders.Update(order);
            await _db.SaveAsync();
        }
    }
}