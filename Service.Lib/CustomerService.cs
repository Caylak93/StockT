using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Service.Lib.Model;
using Service.Lib.Model.Request;
using Service.Lib.Model.Result;
using Service.Lib.Repository;
using Stock.Lib.UnitOfWork;
using StockDb;
using StockDb.Entities;

namespace Service.Lib
{
    public class CustomerService : ICustomerService, IRepository<CustomerModel>
    {
        public Model.Result.CustomerAddResult AddCustomer(CustomerAddRequest request)
        {
            CustomerAddResult result = new CustomerAddResult();
            try
            {

                if (request != null && request.CustomerModel != null)
                {
                    using (StockDbContext context = new StockDbContext())
                    using (IUnitOfWork unitofwork = new EfUnitOfWork(context))
                    {
                        Customer customer = new Customer
                        {
                            CustomerId = Guid.NewGuid(),
                            City = request.CustomerModel.City,
                            CompanyName = request.CustomerModel.CompanyName,
                            Address = request.CustomerModel.Address,
                            Region = request.CustomerModel.Region,
                            Phone = request.CustomerModel.Phone,
                            ContactTitle = request.CustomerModel.ContactTitle,
                            ContactName = request.CustomerModel.ContactName,
                            PostalCode = request.CustomerModel.PostalCode,
                            Country = request.CustomerModel.Country,
                            Fax = request.CustomerModel.Fax,
                        };
                        unitofwork.GetRepository<Customer>().Add(customer);
                        result.SaveCount = unitofwork.SaveChanges();
                        if (result.SaveCount > 0)
                        {
                            return result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return result;
        }







        public IQueryable<CustomerModel> GetAll() 
        {

            using (StockDbContext context = new StockDbContext())
            using (IUnitOfWork unitOfWork = new EfUnitOfWork(context))
            {
                var customer = unitOfWork.GetRepository<Customer>().GetAll();

                IQueryable<CustomerModel> customerModels = customer.Select(s => new CustomerModel
                {
                    Address = s.Address,
                    Region = s.Region,
                    CompanyName = s.CompanyName,
                    City = s.City,
                    Phone = s.Phone,
                    ContactName = s.ContactName,
                    PostalCode = s.PostalCode,
                    Country = s.Country,
                    ContactTitle = s.ContactTitle,
                    Fax = s.Fax

                }).AsQueryable();

                return customerModels;
            }
        }

        public List<CustomerModel> GetAlls()
        {

            using (StockDbContext context = new StockDbContext())
            using (IUnitOfWork unitOfWork = new EfUnitOfWork(context))
            {
                var customer = unitOfWork.GetRepository<Customer>().GetAll();

                List<CustomerModel> customerModels = customer.Select(s => new CustomerModel
                {
                    Address = s.Address,
                    Region = s.Region,
                    CompanyName = s.CompanyName,
                    City = s.City,
                    Phone = s.Phone,
                    ContactName = s.ContactName,
                    PostalCode = s.PostalCode,
                    Country = s.Country,
                    ContactTitle = s.ContactTitle,
                    Fax = s.Fax

                }).ToList();

                return customerModels;
            }
        }
        public IQueryable<CustomerModel> GetAll(System.Linq.Expressions.Expression<Func<CustomerModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public CustomerModel GetById(Guid id)
        {
            using (StockDbContext context = new StockDbContext())
            using (IUnitOfWork unitOfWork = new EfUnitOfWork(context))
            {

                var customer = unitOfWork.GetRepository<Customer>().GetById(id);
                CustomerModel customerModel = new CustomerModel
                {
                    City = customer.City,
                    CompanyName = customer.CompanyName,
                    Address = customer.Address,
                    Region = customer.Region,
                    Phone = customer.Phone,
                    ContactTitle = customer.ContactTitle,
                    ContactName = customer.ContactName,
                    PostalCode = customer.PostalCode,
                    Country = customer.Country,
                    Fax = customer.Fax,
                };
               return customerModel;
            }
        
        }

        public CustomerModel Get(System.Linq.Expressions.Expression<Func<CustomerModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Add(CustomerModel entity)
        {
            try
            {
                if (entity != null)
                {
                    using (StockDbContext context = new StockDbContext())
                    using (IUnitOfWork unitofwork = new EfUnitOfWork(context))
                    {
                        Customer customer = new Customer
                        {
                            CustomerId = Guid.NewGuid(),
                            City = entity.City,
                            CompanyName = entity.CompanyName,
                            Address = entity.Address,
                            Region = entity.Region,
                            Phone = entity.Phone,
                            ContactTitle = entity.ContactTitle,
                            ContactName = entity.ContactName,
                            PostalCode = entity.PostalCode,
                            Country = entity.Country,
                            Fax = entity.Fax,
                        };
                        unitofwork.GetRepository<Customer>().Add(customer);
                        int saveCount = unitofwork.SaveChanges();
                        if (saveCount > 0)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return true;
        }


        public bool Update(CustomerModel entity)
        {
            try
            {
                if (entity != null)
                {
                    using (StockDbContext dbContext = new StockDbContext())
                    using (IUnitOfWork unitOfWork = new EfUnitOfWork(dbContext))
                    {
                        Customer customer = new Customer
                        {
                            City = entity.City,
                            CompanyName = entity.CompanyName,
                            Address = entity.Address,
                            Region = entity.Region,
                            Phone = entity.Phone,
                            ContactTitle = entity.ContactTitle,
                            ContactName = entity.ContactName,
                            PostalCode = entity.PostalCode,
                            Country = entity.Country,
                            Fax = entity.Fax,

                        };
                        unitOfWork.GetRepository<Customer>().Update(customer);
                        int saveCount=unitOfWork.SaveChanges();
                        if (saveCount == 0)
                            return false;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return true;
        }

        public bool Delete(CustomerModel entity)
        {

            try
            {
                if (entity != null)
                {
                    using (StockDbContext context = new StockDbContext())
                    using (IUnitOfWork unitofwork = new EfUnitOfWork(context))
                    {
                        Customer customer = new Customer
                        {
                            CustomerId = Guid.NewGuid(),
                            City = entity.City,
                            CompanyName = entity.CompanyName,
                            Address = entity.Address,
                            Region = entity.Region,
                            Phone = entity.Phone,
                            ContactTitle = entity.ContactTitle,
                            ContactName = entity.ContactName,
                            PostalCode = entity.PostalCode,
                            Country = entity.Country,
                            Fax = entity.Fax,
                        };

                        unitofwork.GetRepository<Customer>().Delete(customer);
                        int saveCount = unitofwork.SaveChanges();
                        if (saveCount == 0)
                            return false;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return true;
        }

        public bool Delete(Guid id)
        {
            try
            {
                using (StockDbContext context = new StockDbContext())
                using (IUnitOfWork unitofwork = new EfUnitOfWork(context))
                {
                    unitofwork.GetRepository<Customer>().Delete(id);
                    int savecount = unitofwork.SaveChanges();
                    if (savecount == 0)
                        return false;
                    return true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
