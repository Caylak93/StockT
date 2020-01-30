using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Dto.Model.Product
{

    [DataContract]
    public class ProductDTO
    {

        [DataMember]
        public Guid ProductId { get; set; }

        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public Guid SupplierId { get; set; }
        [DataMember]
        public Guid CategoryId { get; set; }
        [DataMember]
        public string QuantityPerUnit { get; set; }
        [DataMember]
        public decimal? UnitPrice { get; set; }
        [DataMember]
        public short? UnitsInStock { get; set; }
        [DataMember]
        public short? UnitsOnOrder { get; set; }
        [DataMember]
        public short? ReorderLevel { get; set; }
        [DataMember]
        public bool Discontinued { get; set; }
    }
}
