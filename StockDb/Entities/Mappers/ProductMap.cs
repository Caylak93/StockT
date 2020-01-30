using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StockDb.Entities.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductId);

            // Properties
            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.QuantityPerUnit)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Products");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.SupplierId).HasColumnName("SupplierId");
            this.Property(t => t.CategoryId).HasColumnName("CategoryId");
            this.Property(t => t.QuantityPerUnit).HasColumnName("QuantityPerUnit");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.UnitsInStock).HasColumnName("UnitsInStock");
            this.Property(t => t.UnitsOnOrder).HasColumnName("UnitsOnOrder");
            this.Property(t => t.ReorderLevel).HasColumnName("ReorderLevel");
            this.Property(t => t.Discontinued).HasColumnName("Discontinued");

            // Relationships
            this.HasRequired(t => t.Category)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.CategoryId);
            this.HasRequired(t => t.Supplier)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.SupplierId);

        }
    }
}
