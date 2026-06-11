namespace BV411.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price {  get; set; }
        public Products(int id,string name,string author,int price) {
            this.Id = id;
            this.Name = name;
            this.Author = author;
            this.Price = price;     
        }
        public override string ToString() {
            return $"{Id}\n{Name} {Author} {Price}ryb";
        }
    }
}
