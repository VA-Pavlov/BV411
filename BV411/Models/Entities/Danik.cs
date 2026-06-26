namespace BV411.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Prise { get; set; }
        public string Linq { get; set; } = "https://localhost:7213/danials/info/";
    }
}
