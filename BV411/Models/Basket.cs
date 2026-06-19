namespace BV411.Models
{
    public class Basket
    {
        public Basket()
        {
            Id = count++;
        }
        public void deleteProd(int id)
        {
           for (int i = 0;i < Products.Count; i++)
            {
                if (Products[i].Id == id)
                {
                    Products.RemoveAt(i);
                    break;
                }
            }
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
