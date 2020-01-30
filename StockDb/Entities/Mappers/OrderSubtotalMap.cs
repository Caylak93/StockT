using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StockDb.Entities.Mapping
{
    public class OrderSubtotalMap : EntityTypeConfiguration<OrderSubtotal>
    {
        public OrderSubtotalMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderId);

            // Properties
            this.Property(t => t.OrderId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OrderSubtotals");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.Subtotal).HasColumnName("Subtotal");
        }
    }
}
