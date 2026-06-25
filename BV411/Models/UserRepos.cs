using System.Collections.Generic;
using System.Linq;

namespace BV411.Models
{
    public static class UserRepos
    {
        private static List<User> users = new();
        private static int _id = 1;

        // REGISTER
        public static User Register(User user)
        {
            user.Id = _id++;
            users.Add(user);
            return user;
        }

        // LOGIN
        public static User Login(string login, string password)
        {
            return users.FirstOrDefault(x =>
                x.Login == login &&
                x.Password == password);
        }

        // GET BY ID
        public static User GetById(int id)
        {
            return users.FirstOrDefault(x => x.Id == id);
        }

        // UPDATE
        public static void Update(User updated)
        {
            var user = users.FirstOrDefault(x => x.Id == updated.Id);

            if (user == null) return;

            user.Login = updated.Login;
            user.Password = updated.Password;
            user.Email = updated.Email;
            user.Phone = updated.Phone;
            user.Avatar = updated.Avatar;
        }
    }
}