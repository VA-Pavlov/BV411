namespace BV411.Models
{
    public static class OrderRepos
    {
        private static List<Order> orders = new();
        private static int nextId = 1;

        public static List<Order> GetByUser(int userId)
        {
            return orders
                .Where(x => x.UserId == userId)
                .OrderByDescending(x => x.CreatedAt)
                .ToList();
        }

        public static Order GetById(int id)
        {
            return orders.FirstOrDefault(x => x.Id == id);
        }

        public static Order CreateFromBasket(Basket basket)
        {
            var order = new Order
            {
                Id = nextId++,
                UserId = basket.UserId,
                Status = "Создан"
            };

            foreach (var p in basket.BasketProducts)
            {
                order.Items.Add(new OrderItem
                {
                    ProductId = p.ProductId,
                    ProductName = p.Product.Name,
                    Price = p.Product.Price,
                    Quantity = p.Quantity
                });
            }

            orders.Add(order);

            return order;
        }

        public static void ChangeStatus(int orderId, string status)
        {
            var order = GetById(orderId);
            if (order != null)
                order.Status = status;
        }
    }
}