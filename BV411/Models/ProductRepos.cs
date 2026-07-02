namespace BV411.Models
{
    public static class ProductsRepos
    {
        public static List<Product> product { get; set; } = new()
        {
            new Product(){Id = 1, Name = "Ключ от кв. на Чеканной 13", Description = "Ключ от квартиры на улице Чеканая 13 на улицах Таркова", Price = 5000000},
            new Product(){Id = 2, Name = "Олимпийка Adik (Killa Edition)", Description = "Украли у Kill-ы (было тяжко)", Price = 300000},
            new Product(){Id = 3, Name = "Доска с будки Егеря", Description = "Ну украли, и что?", Price = 120000},
            new Product(){Id = 4, Name = "Маска Тагиллы \"Убей\"", Description = "Укралы у Тагиллы (было страшно)", Price = 50000},
            new Product(){Id = 5, Name = "АК-47", Description = "Автомат Калашникова 47 года производства, а что ещё сказать? Самый лучший автомат в мире)", Price = 47000},
            new Product(){Id = 6, Name = "Хирургический набор Survival", Description = "Даёт возможность вылечить себя, не знаю как)", Price = 80000},
        };

        public static int NextId =>
            product.Count == 0 ? 1 : product.Max(x => x.Id) + 1;

        public static Product? Get(int id)
        {
            return product.FirstOrDefault(x => x.Id == id);
        }

        public static void Add(Product productItem)
        {
            productItem.Id = NextId;
            product.Add(productItem);
        }

        public static void Update(Product productItem)
        {
            var old = Get(productItem.Id);

            if (old == null)
                return;

            old.Name = productItem.Name;
            old.Description = productItem.Description;
            old.Price = productItem.Price;
            old.Image = productItem.Image;
        }

        public static void Delete(int id)
        {
            var p = Get(id);

            if (p != null)
                product.Remove(p);
        }
    }
}