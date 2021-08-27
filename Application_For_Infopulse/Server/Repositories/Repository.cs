using Application_For_Infopulse.Server.Data;
using Application_For_Infopulse.Server.Repositories.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application_For_Infopulse.Server.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Create(T item)
        {
            _context.Add(item);
        }

        public void Delete(long id)
        {
            T item = _context.Set<T>().Find(id);
            if (item == null)
                throw new KeyNotFoundException("Item not found");
            _context.Remove(item);
        }

        public T Get(long id)
        {
           return _context.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public IEnumerable<T> GetAllAsync(Func<T, bool> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public void Update(T item)
        {
            _context.Update(item);
        }
    }
}
