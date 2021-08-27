using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application_For_Infopulse.Shared.Models;
using Application_For_Infopulse.Server.Repositories.InterFaces;
using Application_For_Infopulse.Server.Data;

namespace Application_For_Infopulse.Server.Repositories
{
    //public class OrderRepository : IRepository<Order>
    //{
    //    private readonly ApplicationDbContext _context;
    //    List<Order> _orders;
    //    public OrderRepository(ApplicationDbContext context)
    //    {

    //        _orders = new List<Order>
    //                {
    //                    new Order { Id=1, OrderNumber=1, Customer= null, TotalCost= 100, Status=OrderStutus.New },
    //                    new Order { Id=2, OrderNumber=2, Customer= null, TotalCost= 200, Status=OrderStutus.Paid},
    //                    new Order { Id=3, OrderNumber=3, Customer= null, TotalCost= 300, Status=OrderStutus.Shipped },
    //                    new Order { Id=4, OrderNumber=4, Customer= null, TotalCost= 400, Status=OrderStutus.Delivered},
    //                    new Order { Id=5, OrderNumber=99999, Customer= null, TotalCost= 500, Status=OrderStutus.Closed },
    //                };
    //    }
    //public void Create(Order item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Order Get(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public  List<Order> GetAll()
    //    {
    //        return  _orders.ToList();
    //    }

    //    public IEnumerable<Order> GetAllAsync(Func<Order, bool> predicate)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update(Order item)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}

