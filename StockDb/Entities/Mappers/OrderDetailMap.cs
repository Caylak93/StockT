using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StockDb.Entities.Mapping
{
    public class OrderDetailMap : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMap()
        {
            // Primary Key
            //this.HasKey(t => new { t.OrderId, t.ProductId });
            this.HasKey(t => t.OrderDetailId);

            // Properties
            this.Property(t => t.OrderId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OrderDetails");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Discount).HasColumnName("Discount");

            // Relationships
            this.HasRequired(t => t.Order)
                .WithMany(t => t.OrderDetails)
                .HasForeignKey(d => d.OrderId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.OrderDetails)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
