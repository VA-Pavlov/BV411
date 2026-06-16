using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Users
    {
        public int id {  get; set; }
        public string name {  get; set; }
        public string Surname {  get; set; }
        public string Login {  get; set; }
        public string Password {  get; set; }
        public string adres{ get; set; }
        public int RoleId{ get; set; }
        public Roles Role { get; set; }
        public Basket basket { get; set; }
        public List<orders> orders { get; set; }
    }
}
