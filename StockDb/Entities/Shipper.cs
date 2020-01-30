
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace StockDb.Entities
{
    public partial class Shipper 
    {
        public Shipper()
        {
            this.Orders = new List<Order>();
        }

       
        public Guid ShipperId { get; set; }
       
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
