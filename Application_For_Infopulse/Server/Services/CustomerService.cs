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
    public class CustomerService
    {
        private readonly UnitOfWork _db;
        public CustomerService(UnitOfWork db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return (await _db.Customers
                .GetAll()
                .Include(a => a.Orders)
                .ToListAsync())
                .Select(a => {
                    a.OrdersCount = a.Orders.Count;
                    a.TotalOrderCost = a.Orders.Sum(b => b.TotalCost);
                    return a; 
                });
                
        }

        public async Task CreateCustomerAsync(Customer customer)
        {
            _db.Customers.Create(customer);
            await _db.SaveAsync();
        }
    }
}
