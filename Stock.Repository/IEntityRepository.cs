using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Repository
{
    public interface IEntityRepository<T>
    {
        IQueryable<T> Lists();
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        T GetOne(Guid Id);
        
    }
}
