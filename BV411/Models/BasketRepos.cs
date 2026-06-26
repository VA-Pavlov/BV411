namespace BV411.Models
{
    public static class BasketRepos
    {
        private static List<Basket> baskets = new();

        public static Basket GetBasket(int userId)
        {
            var basket = baskets.FirstOrDefault(x => x.UserId == userId);

            if (basket == null)
            {
                basket = new Basket
                {
                    Id = baskets.Count + 1,
                    UserId = userId
                };

                baskets.Add(basket);
            }

            return basket;
        }
    }
}