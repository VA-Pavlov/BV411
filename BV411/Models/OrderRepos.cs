namespace BV411.Models
{
    public static class OrderRepos
    {
        private static int nextId = 1;

        public static List<Order> GetByUser(int userId)
        {
            var user = UserRepos.Get(userId);

            if (user == null)
                return new List<Order>();

            return user.Orders
                .OrderByDescending(x => x.CreatedAt)
                .ToList();
        }

        public static Order? GetById(int id)
        {
            foreach (var user in UserRepos.Users)
            {
                var order = user.Orders.FirstOrDefault(x => x.Id == id);

                if (order != null)
                    return order;
            }

            return null;
        }

        public static Order CreateFromBasket(Basket basket)
        {
            var user = UserRepos.Get(basket.UserId);

            if (user == null)
                throw new Exception("Пользователь не найден");

            var order = new Order
            {
                Id = nextId++,
                UserId = user.Id,
                Status = "Создан"
            };

            foreach (var group in basket.Products.GroupBy(x => x.Id))
            {
                var product = group.First();

                order.Items.Add(new OrderItem
                {
                    ProductId = product.Id,
                    ProductName = product.Name,
                    Price = product.Price,
                    Quantity = group.Count()
                });
            }

            user.Orders.Add(order);

            return order;
        }

        public static void ChangeStatus(int id, string status)
        {
            var order = GetById(id);

            if (order != null)
                order.Status = status;
        }
    }
}