using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using StockDb;


namespace Service.Lib.Repository
{
    public class EfRepository<T> : IRepository<T> where T : class
    {
        private readonly StockDbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public EfRepository(StockDbContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException("dbContext can not be null");

            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }


        public T Get(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Find(predicate);
        }

        public bool Add(T entity)
        {
            if (entity == null)
                return false;
            _dbSet.Add(entity);
            return true;
        }


        public bool Delete(T entity)
        {
            DbEntityEntry dbEntityEntry = _dbContext.Entry(entity);
            if (dbEntityEntry == null)
                return false;

            if (dbEntityEntry.State != EntityState.Deleted)
                dbEntityEntry.State = EntityState.Deleted;
            else
            {
                _dbSet.Attach(entity);
                _dbSet.Remove(entity);
            }

            return true;
        }

        public bool Update(T entity)
        {
            _dbSet.Attach(entity);
            var entry = _dbContext.Entry(entity);
            entry.State = EntityState.Modified;
            //_dbContext.Entry(entity).State = EntityState.Modified;

            return true;
        }


        public T GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public bool Delete(Guid id)
        {
            var entity = GetById(id);
            if (entity == null)
                return false;

            Delete(entity);
            return true;
        }
    }
}
