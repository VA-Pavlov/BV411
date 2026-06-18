namespace BV411.Models
{
    public static class BasketRepos
    {
        static private List<Basket> baskets = new List<Basket>()
        {
            new Basket(),
            new Basket()
        };

        public static Basket GetBasket(int id)
        {
            return baskets[id];
        }
    }
}
