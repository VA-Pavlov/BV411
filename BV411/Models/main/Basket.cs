using BV411.Models.transport;

namespace BV411.Models.main
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
                if (Products[i].product.Id == id)
                {
                    Products[i].count--;
                    if(Products[i].count <= 0)
                        Products.RemoveAt(i);
                    break;
                }
           }
           
        }
        static int count {  get; set; } = 0;
        public int Id { get; set; }
        public List<basketProducts> Products { get; set; } = new List<basketProducts>();
        public int Count { get {
                return Products.Count;
            }
        }
        public double prise
        {
            get
            {
                return Products.Sum(product => product.price);
            }
        }
        public int IdUser { get; set; }
        public void addProduct(product product)
        {
            bool flag = true;
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].product.Id == product.Id)
                {
                    flag = false;
                    Products[i].count++;
                    break;
                }
            }
            if (flag)
            {
                Products.Add(new basketProducts(product));
            }
        }
    }
}
