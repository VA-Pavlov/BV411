using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace BV411.Models
{
    public static class DanikRepos
    {
        public static List<Danik> Daniks { get; set; } = new List<Danik>()
        {
            new Danik(){Id = 1, Name = "Danik", Description = "Not a Daniil"},
            new Danik(){Id = 2, Name = "Daniil", Description = "Not a Daniil"},
            new Danik(){Id = 3, Name = "Maksim", Description = "Not a Daniil and not a Danik"},
        };
    }
}
