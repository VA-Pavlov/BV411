namespace BV411.Models
{
    public static class DanyPepos
    {
        public static List<Danik> DanikList { get; set; } = new List<Danik>()
        {
            new Danik(){Id = 1,Name = "Danik", Description="Не Даниил!", Prise = 6000},
            new Danik(){Id = 2,Name = "Даниил", Description="Не Дэни!", Prise = 10},
            new Danik(){Id = 2,Name = "Vania", Description="Не Дэни!", Prise = 10.5},
            new Danik(){Id = 3,Name = "Маша", Description="Не Даниил и не Даник!", Prise=100000 }
        };
    }
}
