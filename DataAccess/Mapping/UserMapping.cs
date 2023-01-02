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
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            this.HasKey(x => x.UserID);

            this.Property(x => x.UserID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
             .IsRequired();

            this.Property(x => x.UserName).HasMaxLength(25).IsRequired();
            this.Property(x => x.Password).IsRequired();            
        }
    }
}
