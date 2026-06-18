namespace BV411.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public List<Danik> Products { get; set; } = new List<Danik>();
        public int Count { get{ return Products.Count;} }
        public double Price { get { return Products.Sum(i => i.Prise); } }
        static int CountId = 0;
        public Basket() { CountId++; Id = CountId; }
    }
}
