using Stock.Dto.Model.Product;
using Stock.WCFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Stock.ServiceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductService" in both code and config file together.
    [ServiceContract]
    public interface IProductService:IServiceBase<ProductDTO>
    {
       
    }
}
