using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using StockDb;

namespace Service.Lib.Repository
{
    public class EfTransactionRepository<T> : IRepository<T> where T : class
    {
        private readonly StockDbContext _dbContext;
        private readonly IRepository<T> _repository;
        private IsolationLevel _isolationLevel = IsolationLevel.Serializable;
 
        public IsolationLevel IsolationLevel
        {
            get
            {
                return _isolationLevel;
            }
 
            set
            {
                _isolationLevel = value;
            }
        }
 
        public EfTransactionRepository(StockDbContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException("dbContext boş");
 
            _dbContext = dbContext;
            _repository = new EfRepository<T>(_dbContext);
        } 
 
        public IQueryable<T> GetAll()
        {
            return RunWithTransaction<IQueryable<T>>(() => { return _repository.GetAll(); });
        }
 
        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return RunWithTransaction<IQueryable<T>>(() => { return _repository.GetAll(predicate); });
 
        }
 
        public T GetById(Guid id)
        {
            return RunWithTransaction<T>(() => { return _repository.GetById(id); });
        }
 
        public T Get(Expression<Func<T, bool>> predicate)
        {
            return RunWithTransaction<T>(() => { return _repository.Get(predicate); });
        }

        public bool Add(T entity)
        {
            RunWithTransaction(() => { _repository.Add(entity); });
            return true;
        }

        public bool Delete(Guid id)
        {
            RunWithTransaction(() => { _repository.Delete(id); });
            return true;
        }

        public bool Delete(T entity)
        {
            RunWithTransaction(() => { _repository.Delete(entity); });
            return true;
        }

        public bool Update(T entity)
        {
            RunWithTransaction(() => { _repository.Update(entity); });
            return true;
        }
 
        public K RunWithTransaction<K>(Func<K> func)
        {
            using (_dbContext.Database.BeginTransaction(IsolationLevel))
            {
                return func();
            }
        } 
 
        public void RunWithTransaction(Action func)
        {
            using (_dbContext.Database.BeginTransaction(IsolationLevel))
            {
                func();
            }
        }
    }

    
}