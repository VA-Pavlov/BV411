namespace BV411.Models
{
    public static class BasketRepos
    {
        private static List<Basket> baskets = new();

        public static Basket GetBasket(int id)
        {
            var basket = baskets.FirstOrDefault(b => b.Id == id);

            if (basket == null)
            {
                basket = new Basket { Id = id };
                baskets.Add(basket);
            }

            return basket;
        }
    }
}