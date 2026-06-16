using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Basket
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public Users User { get; set; }
        public List<product> Products { get; set; }

    }
}
