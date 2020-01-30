using Service.Lib.Model.Request;
using Service.Lib.Model.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Lib
{
    public interface IProductService
    {
        ProductAddResult AddCustomer(ProductAddRequest request);
    }
}
