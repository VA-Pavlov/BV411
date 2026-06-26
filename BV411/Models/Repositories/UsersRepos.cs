using BV411.Models.Entities;

namespace BV411.Models.Repositories
{
    public static class UsersRepos
    {
        static public List<User> Users = new List<User>()
        {
            new User("Вячеслав","Павлов","clavik_2000@mail.ru","123456","г.Санкт-Петербург, ул.Итальянская 6Б, кв 5"),
            new User("Иван","Травников","trava_xxl@gmail.ru","123","г.Санкт-Петербург, ул.Александра Невского 6Б, кв 5")

        };

        public static User ActiveUser { get; set; } = Users[0];
    }
}
