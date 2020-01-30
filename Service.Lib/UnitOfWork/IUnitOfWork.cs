using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Lib.Repository;

namespace Stock.Lib.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;
        int SaveChanges();
    }
}
