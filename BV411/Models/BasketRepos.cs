namespace BV411.Models
{
    public static class BasketRepos
    {
        public static Basket GetByUser(int userId)
        {
            var user = UserRepos.Get(userId);

            if (user == null)
                throw new Exception("Пользователь не найден");

            user.Basket.UserId = userId;

            return user.Basket;
        }

        public static void Clear(int userId)
        {
            GetByUser(userId).Products.Clear();
        }
    }
}