using Stock.Dto.Model.Product;
using Stock.Repository;
using Stock.ServiceLib;
using StockDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLib
{
    public class ProductService:IProductService
    {
        ProductRepository rep = new ProductRepository();


        public IQueryable<Stock.Dto.Model.Product.ProductDTO> Lists()
        {
            return rep.Lists().Select(x => new ProductDTO
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                UnitPrice = x.UnitPrice,
                UnitsInStock = x.UnitsInStock
            });
        }

        public bool Add(Stock.Dto.Model.Product.ProductDTO entity)
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

        public bool Update(Stock.Dto.Model.Product.ProductDTO entity)
        {
            Product update = rep.Context.Set<Product>().FirstOrDefault(x => x.ProductId == entity.ProductId);

            update.ProductId = entity.ProductId;
            update.ProductName = entity.ProductName;
            update.UnitPrice = entity.UnitPrice;
            update.UnitsInStock = entity.UnitsInStock;
            return rep.Update();

        }

        public bool Delete(Stock.Dto.Model.Product.ProductDTO entity)
        {
            Product delete = rep.GetOne(entity.ProductId);
            return rep.Delete(delete);
        }




    }
}
