using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockT.Model
{
    public class OrderViewModel
    {
        public Guid OrderId { get; set; }

        public Guid CustomerId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        //public virtual Customer Customer { get; set; }
        //public virtual Employee Employee { get; set; }
        //public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        //public virtual Shipper Shipper { get; set; }
    }
}
