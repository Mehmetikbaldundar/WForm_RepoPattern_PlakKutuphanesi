using DataAccess.Context;
using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class AlbumRepository : BaseRepository<Album>
    {
        public AlbumRepository(MyDbContext sirketDbContext) : base(sirketDbContext)
        {
        }
    }
}
