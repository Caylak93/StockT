
using System;
using System.Collections.Generic;


namespace StockDb.Entities
{
    public partial class AlphabeticalListOfProduct 
    {
        public Guid Id { get; set; }
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
        public string CategoryName { get; set; }
    }
}
