using StockDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Repository
{
    public class ProductRepository : RepositoryBase<Product>
    {

        public override Product GetOne(Guid Id)
        {
            return Context.Set<Product>().SingleOrDefault(x => x.ProductId == Id);
        }

        public bool Update()
        {
            Context.SaveChanges();
            return true;
        }
    }
}
