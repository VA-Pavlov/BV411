namespace BV411.Models
{
    public static class ProductsRepos
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product("1","RTX 4070", 60000),
            new Product("2","RTX 4080", 70000),
            new Product("3","RTX 4090", 80000),
            new Product("4","Intel I7-14700K", 35000),
            new Product("5","Ryzen 7 7800x3d", 30000),
            new Product("6","Ryzen 9 7900x", 25000),
        };
    }
}
