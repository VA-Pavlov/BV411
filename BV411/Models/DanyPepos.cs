namespace BV411.Models
{
    public static class DanyPepos
    {
        public static List<Product> ProductList { get; set; } = new List<Product>()
        {
            new Product(){Id = 1,Name = "Product", Description="Не Даниил!", Prise = 6000},
            new Product(){Id = 2,Name = "Даниил", Description="Не Дэни!", Prise = 10},
            new Product(){Id = 3,Name = "Vania", Description="Не Дэни!", Prise = 10.5},
            new Product(){Id = 4,Name = "Маша", Description="Не Даниил и не Даник!", Prise=100000 }
        };
    }
}
