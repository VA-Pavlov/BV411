using BV411.Models.Entities;

namespace BV411.Models.Repository
{
    public static class DanyPepos
    {
        public static List<Product> DanikList { get; set; } = new List<Product>()
        {
            new (){Id = 1,Name = "Danik", Description="Не Даниил!", Prise = 6000},
            new (){Id = 2,Name = "Даниил", Description="Не Дэни!", Prise = 10},
            new (){Id = 3,Name = "Vania", Description="Не Дэни!", Prise = 10.5},
            new (){Id = 4,Name = "Маша", Description="Не Даниил и не Даник!", Prise=100000 }
        };
    }
}
