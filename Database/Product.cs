using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string PictureLinq { get; set; }
        public string Description { get; set; }
        public List <Basket> Baskets { get; set; }
        public List<Order> Orders { get; set; }

    }
}
