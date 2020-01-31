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
    public class CategoryService : IRepository<CategoryModel>
    {
        public List<CategoryModel> GetAlls()
        {

            using (StockDbContext context = new StockDbContext())
            using (IUnitOfWork unitOfWork = new EfUnitOfWork(context))
            {
                var category = unitOfWork.GetRepository<Category>().GetAll();

                List<CategoryModel> categoryModels = category.Select(s => new CategoryModel()
                {
                    CategoryId = s.CategoryId,
                    CategoryCode = s.CategoryCode,
                    CategoryName = s.CategoryName,
                    Description = s.Description,
                    Picture = s.Picture

                }).ToList();

                return categoryModels;
            }
        }

        public IQueryable<CategoryModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<CategoryModel> GetAll(System.Linq.Expressions.Expression<Func<CategoryModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public CategoryModel GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public CategoryModel Get(System.Linq.Expressions.Expression<Func<CategoryModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Add(CategoryModel entity)
        {
            try
            {
                using (StockDbContext context = new StockDbContext())
                using (IUnitOfWork unitofwork = new EfUnitOfWork(context))
                {
                    entity.CategoryId = Guid.NewGuid();
                    Category category = StockMapper.CategoryMap(entity);
                    unitofwork.GetRepository<Category>().Add(category);
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

        public bool Update(CategoryModel entity)
        {
            try
            {
                using (StockDbContext context = new StockDbContext())
                using (IUnitOfWork unitofwork = new EfUnitOfWork(context))
                {
                    var category = unitofwork.GetRepository<Category>().GetById(entity.CategoryId);
                    category.CategoryName = entity.CategoryName;
                    category.Description = entity.Description;
                    unitofwork.GetRepository<Category>().Update(category);
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

        public bool Delete(CategoryModel entity)
        {
            try
            {
                using (StockDbContext context = new StockDbContext())
                using (IUnitOfWork unitofwork = new EfUnitOfWork(context))
                {
                    Category category = StockMapper.CategoryMap(entity);
                    unitofwork.GetRepository<Category>().Delete(category);
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
                   
                    unitofwork.GetRepository<Category>().Delete(id);
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
    }

}
