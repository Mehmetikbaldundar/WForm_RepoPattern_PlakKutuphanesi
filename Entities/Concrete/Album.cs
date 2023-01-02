using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Album : IAlbum, IBaseEntity
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountRate { get; set; }
        public SaleStatus SaleStatus { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}
