namespace BV411.Models
{
    public class Basket
    {
        public Basket()
        {
            Id = count++;
        }

        static int count {  get; set; } = 0;
        public int Id { get; set; }
        public List<product> Products { get; set; }
        public int Count { get {
                return Products.Count;
            }
        }
        public int prise
        {
            get
            {
                return Products.Sum(product => product.price);
            }
        }
        public int IdUser { get; set; }
    }
}
