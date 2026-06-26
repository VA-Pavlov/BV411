using BV411.Models.main;

namespace BV411.Models.transport
{
    public class basketProducts
    {
        public basketProducts(product product)
        {
            this.product = product;
            count = 1;
        }

        public int Id { get; set; }
        public int count { get; set; }
        public product product { get; set; }
        public double price { get { return count * product.price; } }
    }
}
