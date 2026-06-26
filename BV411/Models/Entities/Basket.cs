using BV411.Models.Models;
namespace BV411.Models.Entities
{
    public class Basket {
        public int Id { get; set; }
        public User User { get; set; }
        public List<ProductInBasket> Products { get; set; } = [];
        public int Count { get{ return Products.Count;} }
        public double Price { get { return Products.Sum(i => i.Price); } }
        static int CountId = 0;
        public Basket(User user) { CountId++; Id = CountId; User = user; }
        public void AddProduct(ProductInBasket product)
        {
            var BAsketProduct = Products.FirstOrDefault(pr => pr.Product.Id == product.Product.Id);
            if (BAsketProduct != null) { BAsketProduct.Count++; }
            else {  Products.Add(new ProductInBasket(product.Product)); }
        }
    }
}