using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class product
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public string PictureLinq { get; set; }
        public List<Basket> Baskets { get; set; }
        public List<orders> orders { get; set; }
    }
}
