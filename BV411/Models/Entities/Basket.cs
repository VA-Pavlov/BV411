using BV411.Models.ModelsForViews;

namespace BV411.Models.Entities
{
    public class Basket
    {
        public int Id { get; set; }
        public User User { get; set; }
        public List<ProduktInBasket> Products { get; } = new List<ProduktInBasket>();
        public int Count { get { return Products.Count; } }
        public double Price { get { return Products.Sum(i => i.Price); } }
        static int CountId = 0;
        public Basket(User user) 
        { 
            CountId++; 
            Id = CountId; 
            User = user;
        }
        public void AddProduct(Product product)
        {
            var basketProduct = Products
                .FirstOrDefault(pr => pr.Product.Id == product.Id);
            if (basketProduct != null)
            {
                basketProduct.Count++;
            }else
            {
                Products.Add(new ProduktInBasket(product));
            }

        }
    }
}
