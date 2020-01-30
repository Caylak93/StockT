using System;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using Service.Lib.Repository;
using Stock.Lib.UnitOfWork;
using StockDb;


namespace Stock.Lib.UnitOfWork
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private bool _disposed = false;
        private readonly StockDbContext _dbContext;
 
        public EfUnitOfWork(StockDbContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException("boş"); 
 
            _dbContext = dbContext;
        }
 
        public IRepository<T> GetRepository<T>() where T : class
        {
            return new EfRepository<T>(_dbContext);
        }
 
        public int SaveChanges()
        {
            try
            {
                return _dbContext.SaveChanges();

            }
            catch (OptimisticConcurrencyException ex)
            {
                Console.WriteLine(ex);
                throw;
                //TODO : handle exceptions
                throw;
                //var context = ((IObjectContextAdapter)_dbContext  ).ObjectContext;
                //// Resolve the concurrency conflict by refreshing the
                //// object context before re-saving changes.
                //context.Refresh(RefreshMode.ClientWins, orders);
 
                //// Save changes.
                //context.SaveChanges();
                //Console.WriteLine("OptimisticConcurrencyException "
                //+ "handled and changes saved");
            }
            catch (CommitFailedException ex)
            {
                //TODO : handle exceptions
                return _dbContext.SaveChanges();
            }
            catch (EntityException ex)
            {
                //TODO : handle exceptions
                return _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
 
        public virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
 
            this._disposed = true;
        }
 
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}