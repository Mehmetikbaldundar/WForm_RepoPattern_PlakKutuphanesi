using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class AlbumMapping : EntityTypeConfiguration<Album>
    {
        public AlbumMapping()
        {
            this.HasKey(x => x.ID);

            this.Property(x => x.ID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
             .IsRequired();
            this.Property(x => x.Name).HasMaxLength(25).IsRequired();
            this.Property(x => x.Artist).HasMaxLength(50).IsRequired();
            this.Property(x => x.ReleaseDate).IsRequired();
            this.Property(x => x.Price).IsRequired().HasColumnType("decimal").HasPrecision(18, 2);
            this.Property(x => x.DiscountRate).IsOptional();
        }


    }
}
