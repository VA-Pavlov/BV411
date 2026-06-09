namespace BV411.Models
{
    public class productModels
    {
        public int ip;
        public string name;
        public string description;
        public int prise;

        public productModels(int ip, string name, string description, int prise)
        {
            this.ip = ip;
            this.name = name;
            this.description = description;
            this.prise = prise;
        }
        public override string ToString()
        {
            return $"{name}, {description}, {prise}\n";
        }
    }
}
