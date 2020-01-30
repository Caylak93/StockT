
using System;
using System.Collections.Generic;


namespace StockDb.Entities
{
    public partial class OrderDetail 
    {
        public Guid OrderDetailId { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
