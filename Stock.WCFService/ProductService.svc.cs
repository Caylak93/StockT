using Stock.Dto.Model.Product;
using Stock.Repository;
using Stock.ServiceLib;
using StockDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Stock.WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductService.svc or ProductService.svc.cs at the Solution Explorer and start debugging.
    public class ProductService : IProductService
    {
        ProductRepository rep = new ProductRepository();


        public IQueryable<Dto.Model.Product.ProductDTO> Lists()
        {
            return rep.Lists().Select(x => new ProductDTO
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                UnitPrice = x.UnitPrice,
                UnitsInStock = x.UnitsInStock
            });
        }

        public bool Add(Dto.Model.Product.ProductDTO entity)
        {
            Product product = new Product
            {
                ProductId = entity.ProductId,
                ProductName = entity.ProductName,
                UnitPrice = entity.UnitPrice,
                UnitsInStock = entity.UnitsInStock
            };
            return rep.Add(product);
        }

        public bool Update(Dto.Model.Product.ProductDTO entity)
        {
            Product update = rep.Context.Set<Product>().FirstOrDefault(x =>x.ProductId==entity.ProductId);
          
                update.ProductId = entity.ProductId;
                update.ProductName = entity.ProductName;
                update.UnitPrice = entity.UnitPrice;
                update.UnitsInStock = entity.UnitsInStock;
                return rep.Update();
                

            
            
            
        }

        public bool Delete(Dto.Model.Product.ProductDTO entity)
        {
            Product delete = rep.GetOne(entity.ProductId);
            return rep.Delete(delete);
        }

       
    }
}
