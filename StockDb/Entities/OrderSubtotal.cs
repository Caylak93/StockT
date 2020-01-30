
using System;
using System.Collections.Generic;


namespace StockDb.Entities
{
    public partial class OrderSubtotal
    {
        public Guid OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
