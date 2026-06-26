using BV411.Models.main;

namespace BV411.Models.rip
{
    public class UserRip
    {
        public static User ActivUser { get; set; } = null;
        public static List<User> users = new List<User>() {
            new User("admin", "123"),
            new User("fff", "fff")
        };
    }
}
