namespace BV411.Models
{
    public class Users
    {
        static int count = 1;

        public Users(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public int id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int basketId { get; set; }
    }
}
