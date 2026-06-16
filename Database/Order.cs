using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
        public List<Product> Products { get; set; }
    }
}
