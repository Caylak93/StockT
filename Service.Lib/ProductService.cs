using System;
using System.Collections.Generic;
using System.Linq;
using Service.Lib.Mapper;
using Service.Lib.Model;
using Service.Lib.Repository;
using Stock.Lib.UnitOfWork;
using StockDb;
using StockDb.Entities;

namespace Service.Lib
{
    public class ProductService : IProductService, IRepository<ProductModel>
    {

        public Model.Result.ProductAddResult AddCustomer(Model.Request.ProductAddRequest request)
        {
            throw new NotImplementedException();
        }
        

        public IQueryable<ProductModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAlls()
        {

            using (StockDbContext context = new StockDbContext())
            using (IUnitOfWork unitOfWork = new EfUnitOfWork(context))
            {
                var product = unitOfWork.GetRepository<Product>().GetAll();

                List<ProductModel> productModels = product.Select(s => new ProductModel
                {
                    ProductId = s.ProductId,
                    Discontinued = s.Discontinued,
                    CategoryId = s.CategoryId,
                    SupplierId = s.SupplierId,
                    ProductName = s.ProductName,
                    UnitsInStock = s.UnitsInStock,
                    UnitPrice = s.UnitPrice,
                    QuantityPerUnit = s.QuantityPerUnit,
                    ReorderLevel = s.ReorderLevel,
                    UnitsOnOrder = s.UnitsOnOrder

                }).ToList();

                return productModels;
            }
        }

        public IQueryable<ProductModel> GetAll(System.Linq.Expressions.Expression<Func<ProductModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ProductModel GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public ProductModel Get(System.Linq.Expressions.Expression<Func<ProductModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Add(ProductModel entity)
        {
            try
            {
                using (StockDbContext context = new StockDbContext())
                using (IUnitOfWork unitofwork = new EfUnitOfWork(context))
                {
                    
                    Product product = StockMapper.ProductMap(entity);
                    unitofwork.GetRepository<Product>().Add(product);
                    int saveCount = unitofwork.SaveChanges();
                    if (saveCount == 0)
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

        public bool Update(ProductModel entity)
        {
            try
            {
                using (StockDbContext context = new StockDbContext())
                using (IUnitOfWork unitofwork = new EfUnitOfWork(context))
                {
                    Product product = StockMapper.ProductMap(entity);
                    unitofwork.GetRepository<Product>().Update(product);
                    int saveCount = unitofwork.SaveChanges();
                    if (saveCount == 0)
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

        public bool Delete(ProductModel entity)
        {
            try
            {
                using (StockDbContext context = new StockDbContext())
                using (IUnitOfWork unitofwork = new EfUnitOfWork(context))
                {
                    Product product = StockMapper.ProductMap(entity);
                    unitofwork.GetRepository<Product>().Delete(product);
                    int saveCount = unitofwork.SaveChanges();
                    if (saveCount == 0)
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

        public bool Delete(Guid id)
        {
            try
            {
                using (StockDbContext context = new StockDbContext())
                using (IUnitOfWork unitofwork = new EfUnitOfWork(context))
                {
                    unitofwork.GetRepository<Product>().Delete(id);
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
