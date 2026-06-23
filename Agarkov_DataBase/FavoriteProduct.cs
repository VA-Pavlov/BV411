using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agarkov_DataBase
{
    public class FavoriteProduct
    {
        public int FavoriteId { get; set; }
        public Favorite Favorite { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
