using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Roles
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Roles> users { get; set; }
    }
}
