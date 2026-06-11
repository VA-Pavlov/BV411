using System.Diagnostics;
using BV411.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class HomeController : Controller
    {
        public string Index(int? Id)
        {
            string Result = "";

            if (Id == null)
            {
                foreach (var Product in ProductsRepos.Product)
                {
                    Result += Product + "\n";
                }

                return Result;
            }

            foreach (var Product in ProductsRepos.Product)
            {
                if (Product.Id == Id)
                {
                    return Product.ToString();
                }
            }

            return "Товар не найден";
        }
    }
}
