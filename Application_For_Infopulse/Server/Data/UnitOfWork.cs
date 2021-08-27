using Application_For_Infopulse.Server.Repositories;
using Application_For_Infopulse.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application_For_Infopulse.Server.Data
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private Repository<Order> orderRepository;
        private Repository<Product> productRepository;
        private Repository<Customer> customerRepository;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public Repository<Order> Orders
        {
            get
            {
                orderRepository = orderRepository ?? new Repository<Order>(_context);
                return orderRepository;
            }
        }

        public Repository<Product> Products
        {
            get
            {
                productRepository = productRepository ?? new Repository<Product>(_context);
                return productRepository;
            }
        }

        public Repository<Customer> Customers
        {
            get
            {
                customerRepository = customerRepository ?? new Repository<Customer>(_context);
                return customerRepository;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        
    }
}
//public TeacherRepository Teachers
//{
//    get
//    {
//        teacherRepository = teacherRepository ?? new TeacherRepository(_context);
//        return teacherRepository;
//    }

//}