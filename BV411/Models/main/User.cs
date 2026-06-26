namespace BV411.Models.main
{
    public class User
    {
        static int count = 1;

        public User(string login, string password)
        {
            Login = login;
            Password = password;
            id = count;
            count++;
        }

        public int id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string ava { get; set; } = "https://avatars.mds.yandex.net/i?id=32d0917f2ea866e29e21119f0abf13b93d1b5463-12421862-images-thumbs&n=13";
        public Basket Basket{ get; set; } = new Basket();
        public int money { set; get; }
    }
}
