using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StockDb.Entities.Mapping
{
    public class OrderDetailsExtendedMap : EntityTypeConfiguration<OrderDetailsExtended>
    {
        public OrderDetailsExtendedMap()
        {
            // Primary Key
            //this.HasKey(t => new { t.OrderId, t.ProductId, t.ProductName, t.UnitPrice, t.Quantity, t.Discount });
            this.HasKey(t => t.OrderDetailExtendedId);

            // Properties
            this.Property(t => t.OrderId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.UnitPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Quantity)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OrderDetailsExtended");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.ExtendedPrice).HasColumnName("ExtendedPrice");
        }
    }
}
