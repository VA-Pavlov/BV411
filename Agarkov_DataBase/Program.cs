using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agarkov_DataBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Console.WriteLine("База данных создана.");

                // Добавление данных
                Role role = new Role
                {
                    Name = "Admin"
                };

                db.roles.Add(role);
                db.SaveChanges();

                Console.WriteLine("Роль добавлена.");

                // Вывод данных
                var roles = db.roles.ToList();

                foreach (var item in roles)
                {
                    Console.WriteLine(item.Name);
                }
            }

            Console.ReadKey();
        }
    }
}
