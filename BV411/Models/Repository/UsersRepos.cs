using BV411.Models.Entities;
namespace BV411.Models.Repository {
    public class UsersRepos {
        public static List<User> Users = [
            new ("Павел","Шило","shilo_4748.ru","123456","г.спб, улица мира б7б кв3"),
            new ("Анатоли","Шиглов","shi_478.ru","123456","г.спб, улица мира б79 кв65")
        ];
        public static User AktiveUser { get; set; } = Users[0];
    }
}