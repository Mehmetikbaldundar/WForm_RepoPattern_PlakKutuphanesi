using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IUser
    {
        int UserID { get; set; }
        string UserName { get; set; }
        string Password { get; set; }


    }
}
