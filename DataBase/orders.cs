using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class orders
    {
        public int id;
        public int UserID { get; set; }
        public int StasysId { get; set; }
        public Status Status { get; set; }
        public DateTime Date { get; set; }
        public Users User { get; set; }
        public List<product> Products { get; set; }
    }
}
