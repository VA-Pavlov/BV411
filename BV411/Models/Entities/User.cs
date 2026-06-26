using System.Diagnostics.Metrics;

namespace BV411.Models.Entities {
    public class User {
        public static int Counter = 0;
        public User(string name, string surname, string email, string password, string adress) {
            Id = Counter; 
            Counter++; 
            Name = name;
            Surname = surname; Email = email;
            Password = password; Basket = new Basket(this);
            Adress = adress; Orders = [];
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Basket Basket {  get; set; }
        public string Adress {  get; set; }
        List<Order> Orders { get; set; } 
    }
}