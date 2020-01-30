
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace StockDb.Entities
{
    public partial class Product 
    {
        public Product()
        {
            this.OrderDetails = new List<OrderDetail>();
        }

       
        public Guid ProductId { get; set; }
        
        public string ProductName { get; set; }
        public Guid SupplierId { get; set; }
        public Guid CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
