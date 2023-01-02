using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IAlbum
    {
        int ID { get; set; }
        string Name { get; set; }
        string Artist { get; set; }
        DateTime ReleaseDate { get; set; }
        decimal Price { get; set; }
        decimal DiscountRate { get; set; }
        SaleStatus SaleStatus { get; set; }




    }
}
