using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Stock.ServiceLib
{
    [ServiceContract]
    public interface IServiceBase<DTO>
    {
        [OperationContract]
        IQueryable<DTO> Lists();
        [OperationContract]
        bool Add(DTO entity);

        [OperationContract]
        bool Update(DTO entity);

        [OperationContract]
        bool Delete(DTO entity);



    }
}
