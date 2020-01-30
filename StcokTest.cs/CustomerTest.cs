using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stock.Lib.UnitOfWork;
using StockDb;
using StockDb.Entities;

namespace StcokTest.cs
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            using (StockDbContext context = new StockDbContext())
            using (IUnitOfWork unitofwork = new EfUnitOfWork(context))
            {
                Customer customer = new Customer
                {
                    CustomerId = Guid.NewGuid(),
                    City = "ankara",
                    CompanyName = "Tc",
                    Address = "Yenımahalle",
                    Region = "Tr",
                    Phone = "5555555",
                    ContactTitle = "Onuur",
                    ContactName = "Onur",
                    PostalCode = "000",
                    Country = "Turkiye",
                    Fax = "00000",
                };
                unitofwork.GetRepository<Customer>().Add(customer);
                int saveCount = unitofwork.SaveChanges();
            }
        }

        [TestMethod]
        public void TestMethodDelete()
        {
            using (StockDbContext context = new StockDbContext())
            using (IUnitOfWork unitofwork = new EfUnitOfWork(context))
            {
                Customer customer = new Customer
                {
                    CustomerId = new Guid("1B67D5CA-CFFD-447C-84BA-49651E9CE601"),
                    City = "ankara",
                    CompanyName = "Tc",
                    Address = "Yenımahalle",
                    Region = "Tr",
                    Phone = "5555555",
                    ContactTitle = "Onuur",
                    ContactName = "Onur",
                    PostalCode = "000",
                    Country = "Turkiye",
                    Fax = "00000",
                };
                Guid Id = new Guid("1B67D5CA-CFFD-447C-84BA-49651E9CE601");
                unitofwork.GetRepository<Customer>().Delete(Id);
                unitofwork.SaveChanges();
            }
        }
        [TestMethod]
        public void TestMethodUpdate()
        {
            using (StockDbContext context = new StockDbContext())
            using (IUnitOfWork unitofwork = new EfUnitOfWork(context))
            {
                Customer customer = new Customer
                {
                    CustomerId = new Guid("6CA80A72-F581-4E95-98AB-20DA9E310808"),
                    City = "Niğde",
                    CompanyName = "Çiftliği",
                    Address = "Yenımahalle",
                    Region = "Tr",
                    Phone = "5555555",
                    ContactTitle = "Ali",
                    ContactName = "Babanın",
                    PostalCode = "000",
                    Country = "Turkiye",
                    Fax = "00000",
                };
                Guid Id = new Guid("6CA80A72-F581-4E95-98AB-20DA9E310808");
                unitofwork.GetRepository<Customer>().Update(customer);
                unitofwork.SaveChanges();
            }
        }
       
            [TestMethod]
            public void 
                
                TestMethodProductAdd()
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
                    unitofwork.SaveChanges();
                }
            }
        }
    }

