using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application_For_Infopulse.Server.Repositories.InterFaces
{
    interface IRepository<T> where T : class
    {
        T Get(long id);
        IQueryable<T> GetAll();
        IEnumerable<T> GetAllAsync(Func<T, bool> predicate);
        void Create(T item);
        void Update(T item);
        void Delete(long id);
    }
}
