namespace BV411.Models
{
    public static class BasketRip
    {
        static private List<Basket> baskets = new List<Basket>()
        {
            new Basket(){Id = 0, IdUser = 0, Products = new List<basketProducts>()}
        };
        static public Basket GetBasket(int id)
        {
            return baskets[id];
        }
    }
}
