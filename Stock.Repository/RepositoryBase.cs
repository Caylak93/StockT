using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using StockDb;

namespace Stock.Repository
{
    public class RepositoryBase<T> : IEntityRepository<T> where T : class
    {
        static StockDbContext context;

        public StockDbContext Context
        {
            get
            {
                if (context == null)
                    context = new StockDbContext();
                return context;
            }
            set { context = value; }
        }

        public IQueryable<T> Lists()
        {
            
            return Context.Set<T>();
            
        }

        public bool Add(T entity)
        {
            try
            {

                Context.Set<T>();
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                //Hata loglama
                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                Context.Set<T>().ToList().Remove(entity);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public virtual T GetOne(Guid Id)
        {
            return null;
        }
    }
}
