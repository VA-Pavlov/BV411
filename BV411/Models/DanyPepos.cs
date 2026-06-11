namespace BV411.Models
{
    public static class DanyPepos
    {
        public static List<Danik> DanikList { get; set; } = new List<Danik>()
        {
            new Danik(){Id = 1,Name = "Danik", Description="Не Даниил!" },
            new Danik(){Id = 2,Name = "Даниил", Description="Не Дэни!" },
            new Danik(){Id = 3,Name = "Маша", Description="Не Даниил и не Даник!" }
        };
    }
}
