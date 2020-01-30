using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StockDb.Entities.Mapping
{
    public class RegionMap : EntityTypeConfiguration<Region>
    {
        public RegionMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionId);

            // Properties
            this.Property(t => t.RegionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RegionDescription)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Region");
            this.Property(t => t.RegionId).HasColumnName("RegionId");
            this.Property(t => t.RegionDescription).HasColumnName("RegionDescription");
        }
    }
}
