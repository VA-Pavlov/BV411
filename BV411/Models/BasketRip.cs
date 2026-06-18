namespace BV411.Models
{
    public static class BasketRip
    {
        static private List<Basket> baskets = new List<Basket>()
        {
            new Basket(){Id = 0, IdUser = 0, Products = new List<product> { new product { Name = "дети", Id = 0, Description = "мясо нежное и слкгка соленое", price = 100}, new product { Name = "спортивки киллы", Id = 1, Description = "спортивные штаны фирмы abibas", price = 250} }}
        };
        static public Basket GetBasket(int id)
        {
            return baskets[id];
        }
    }
}
