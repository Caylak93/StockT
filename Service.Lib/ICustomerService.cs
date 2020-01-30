using Service.Lib.Model.Request;
using Service.Lib.Model.Result;

namespace Service.Lib
{
   public interface ICustomerService 
   {
       CustomerAddResult AddCustomer(CustomerAddRequest request);

   }
}
