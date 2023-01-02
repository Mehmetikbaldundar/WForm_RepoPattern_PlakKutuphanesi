using DataAccess.Mapping;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class MyDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<User> Users { get; set; }

        public MyDbContext() : base("Server=DESKTOP-IKBAL\\MSSQLSERVER2019;Database=NRM1-PLAKDATABASE;Trusted_Connection=True;")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlbumMapping())
                                       .Add(new UserMapping());
        }
    }
}
