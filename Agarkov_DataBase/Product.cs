using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agarkov_DataBase
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string PictureLinq { get; set; }
        public List<BasketProduct> BasketProducts { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
    }
}
