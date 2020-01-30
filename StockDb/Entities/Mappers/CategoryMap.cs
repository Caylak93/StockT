using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StockDb.Entities.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            // Primary Key
            
            this.HasKey(t => t.CategoryId);

            // Properties
            this.Property(t => t.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Categories");
            this.Property(t => t.CategoryId).HasColumnName("CategoryId");
            this.Property(t => t.CategoryName).HasColumnName("CategoryName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Picture).HasColumnName("Picture");
        }
    }
}
