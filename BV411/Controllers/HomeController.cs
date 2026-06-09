using System.Diagnostics;
using BV411.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            Products.Prds.Add(new Product(0, "Pickles", 99.99));
            Products.Prds.Add(new Product(1, "Carrot", 69.69));
            Products.Prds.Add(new Product(2, "Tomatoes", 9.11));
            string products = "";
            foreach (var line in Products.Prds)
                products += line + "\n";
            return products;
        }
    }
}
