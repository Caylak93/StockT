using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Lib.Mapper;
using Service.Lib.Model;
using Service.Lib.Repository;
using Stock.Lib.UnitOfWork;
using StockDb;
using StockDb.Entities;

namespace Service.Lib
{
    public class OrderService : IRepository<OrderModel>
    {


        public IQueryable<OrderModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<OrderModel> GetAll(System.Linq.Expressions.Expression<Func<OrderModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public OrderModel GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public OrderModel Get(System.Linq.Expressions.Expression<Func<OrderModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Add(OrderModel entity)
        {
            using (StockDbContext context = new StockDbContext())
            using (IUnitOfWork unitOfWork = new EfUnitOfWork(context))
            {
                Order order = StockMapper.OrderMap(entity);
                unitOfWork.GetRepository<Order>().Add(order);
                int saveCount = unitOfWork.SaveChanges();
                if (saveCount == 0)
                    return false;
                return true;
            }

        }



        public bool Update(OrderModel entity)
        {
            using (StockDbContext context = new StockDbContext())
            using (IUnitOfWork unitOfWork = new EfUnitOfWork(context))
            {
                Order order = StockMapper.OrderMap(entity);
                unitOfWork.GetRepository<Order>().Update(order);
                int saveCount = unitOfWork.SaveChanges();
                if (saveCount == 0)
                    return false;
                return true;

            }
        }

        public bool Delete(OrderModel entity)
        {
            using (StockDbContext context = new StockDbContext())
            using (IUnitOfWork unitOfWork = new EfUnitOfWork(context))
            {
                Order order = StockMapper.OrderMap(entity);
                unitOfWork.GetRepository<Order>().Delete(order);
                int saveCount = unitOfWork.SaveChanges();
                if (saveCount == 0)
                    return false;
                return true;
            }
        }

        public bool Delete(Guid id)
        {
            using (StockDbContext context = new StockDbContext())
            using (IUnitOfWork unitOfWork = new EfUnitOfWork(context))
            {
                unitOfWork.GetRepository<Order>().Delete(id);
                int saveCount = unitOfWork.SaveChanges();
                if (saveCount == 0)
                    return false;
                return true;
            }
        }

    }
}
