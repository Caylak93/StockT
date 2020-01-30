using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Lib.Model.Request
{
    public class CustomerDeleteRequest
    {
        public Guid Id{ get; set; }
        public CustomerModel CustomerModel { get; set; }
    }
}
