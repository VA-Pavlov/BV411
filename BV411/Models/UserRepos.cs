namespace BV411.Models
{
    public static class UserRepos
    {
        private static List<User> users = new();

        static UserRepos()
        {
            users.Add(new User
            {
                Id = 1,
                Login = "admin",
                Password = "123",

                Email = "admin@mail.ru",
                Phone = "+7 (999) 111-11-11",

                Basket = new Basket(),
                Favorite = new Favorite(),
                Orders = new List<Order>()
            });
        }

        public static List<User> Users => users;

        public static User? Get(string login, string password)
        {
            return users.FirstOrDefault(x =>
                x.Login == login &&
                x.Password == password);
        }

        public static User? Get(int id)
        {
            return users.FirstOrDefault(x => x.Id == id);
        }

        public static bool Exists(string login)
        {
            return users.Any(x => x.Login == login);
        }

        public static User Register(
            string login,
            string password,
            string email,
            string phone)
        {
            var user = new User
            {
                Id = users.Count + 1,

                Login = login,
                Password = password,

                Email = email,
                Phone = phone,

                Basket = new Basket(),
                Favorite = new Favorite(),
                Orders = new List<Order>()
            };

            users.Add(user);

            return user;
        }
        public static void Update(User model)
        {
            var user = Get(model.Id);

            if (user == null)
                return;

            user.Login = model.Login;
            user.Email = model.Email;
            user.Phone = model.Phone;
            user.Avatar = model.Avatar;
        }
    }
}