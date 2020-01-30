using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StockDb.Entities.Mapping
{
    public class BaseModelMap : EntityTypeConfiguration<BaseModel>
    {
        public BaseModelMap()
        {
           

            // Properties
            this.Property(t => t.CreateDate);
            this.Property(t => t.ModifiedDate);
            this.Property(t => t.TimeStamp);
            this.Property(t => t.TimeStampValue);
               

            // Table & Column Mappings
            this.ToTable("BaseModel");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            this.Property(t => t.TimeStampValue).HasColumnName("TimeStampValue");
        }
    }
}
