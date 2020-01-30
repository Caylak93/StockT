
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace StockDb.Entities
{
    public partial class Order 
    {
        public Order()
        {
            this.OrderDetails = new List<OrderDetail>();
        }

        
        public Guid OrderId { get; set; }
        
        public Guid CustomerId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int?ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Shipper Shipper { get; set; }
    }
}
