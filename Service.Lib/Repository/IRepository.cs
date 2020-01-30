using System;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Lib.Repository
{
    public interface IRepository<T> where T : class
    {

        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
        T GetById(Guid id);//Teoride ihtiyacımız yok fakat pratikte yararlı oluyor
        T Get(Expression<Func<T, bool>> predicate);

        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Delete(Guid id);
    }
}
