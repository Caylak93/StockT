using System;
using System.Linq;
using Service.Lib.Mapper;
using Service.Lib.Model;
using Service.Lib.Repository;
using Stock.Lib.UnitOfWork;
using StockDb;
using StockDb.Entities;

namespace Service.Lib
{
    public class EmplooyeService : IRepository<EmployeeModel>
    {


        public IQueryable<EmployeeModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<EmployeeModel> GetAll(System.Linq.Expressions.Expression<Func<EmployeeModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public EmployeeModel GetById(Guid id)
        {
            using (StockDbContext context = new StockDbContext())
            using (IUnitOfWork unitOfWork = new EfUnitOfWork(context))
            {
                var employee = unitOfWork.GetRepository<Employee>().GetById(id);
                EmployeeModel employeeModel = StockMapper.EmployeeModelMap(employee);
                return employeeModel;
            }


        }

        public EmployeeModel Get(System.Linq.Expressions.Expression<Func<EmployeeModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Add(EmployeeModel entity)
        {
            using (StockDbContext context = new StockDbContext())
            using (IUnitOfWork unitOfWork = new EfUnitOfWork(context))
            {
                Employee employee = StockMapper.EmployeeMap(entity);
                unitOfWork.GetRepository<Employee>().Add(employee);
                int saveCount = unitOfWork.SaveChanges();
                if (saveCount == 0)
                    return false;
                return true;
            }


        }

        public bool Update(EmployeeModel entity)
        {
            using (StockDbContext context = new StockDbContext())
            using (IUnitOfWork unitOfWork = new EfUnitOfWork(context))
            {
                Employee employee = StockMapper.EmployeeMap(entity);
                unitOfWork.GetRepository<Employee>().Update(employee);
                int saveCount = unitOfWork.SaveChanges();
                if (saveCount == 0)
                    return false;
                return true;
            }
        }


                
            

        public bool Delete(EmployeeModel entity)
        {
            using (StockDbContext context = new StockDbContext())
            using (IUnitOfWork unitOfWork = new EfUnitOfWork(context))
            {
                Employee employee = StockMapper.EmployeeMap(entity);
                unitOfWork.GetRepository<Employee>().Delete(employee);
                int saveCount = unitOfWork.SaveChanges();
                if (saveCount == 0)
                    return false;
                return true;
            }
                
            
        }

        public bool Delete(Guid id)
        {
            using (StockDbContext context = new StockDbContext())
            using (IUnitOfWork unitofwork = new EfUnitOfWork(context))
            {
                unitofwork.GetRepository<Employee>().Delete(id);
                int saveCount = unitofwork.SaveChanges();
                if (saveCount == 0)
                    return false;
                return true;

            }
                
            
        }
    }
}
