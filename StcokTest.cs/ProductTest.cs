using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Lib;
using Service.Lib.Model;
using Stock.Lib.UnitOfWork;
using StockDb;
using StockDb.Entities;

namespace StcokTest.cs
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            using (StockDbContext context = new StockDbContext())
            using (IUnitOfWork unitofwork = new EfUnitOfWork(context))
            {
                Product product = new Product()
                {
                    ProductId = Guid.NewGuid(),
                    Discontinued = true,
                    ProductName = "At",
                    SupplierId = Guid.NewGuid(),
                    CategoryId = Guid.NewGuid(),
                    UnitPrice = 5,
                    UnitsInStock = 15,
                    QuantityPerUnit = "kestanesi",
                    
                };
                    
                unitofwork.GetRepository<Product>().Add(product);
                int saveCount = unitofwork.SaveChanges();
            }
        }
    }
}
