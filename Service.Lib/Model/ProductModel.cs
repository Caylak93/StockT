using System;


namespace Service.Lib.Model
{
    public class ProductModel
    {

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
      
    }
}
