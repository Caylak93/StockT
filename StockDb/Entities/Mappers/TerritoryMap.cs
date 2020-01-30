using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StockDb.Entities.Mapping
{
    public class TerritoryMap : EntityTypeConfiguration<Territory>
    {
        public TerritoryMap()
        {
            // Primary Key
            this.HasKey(t => t.TerritoryId);

            // Properties
            this.Property(t => t.TerritoryId)
                .IsRequired();
                

            this.Property(t => t.TerritoryDescription)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Territories");
            this.Property(t => t.TerritoryId).HasColumnName("TerritoryId");
            this.Property(t => t.TerritoryDescription).HasColumnName("TerritoryDescription");
            this.Property(t => t.RegionId).HasColumnName("RegionId");

            // Relationships
            this.HasRequired(t => t.Region)
                .WithMany(t => t.Territories)
                .HasForeignKey(d => d.RegionId);

        }
    }
}
