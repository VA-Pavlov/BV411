using System.Diagnostics;
using BV411.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class HomeController : Controller
    {


        public string Index()
        {
            string products = "";
            foreach (var line in ProductsRepos.products)
                products += line + "\n";
            return products;
        }


    }
}
