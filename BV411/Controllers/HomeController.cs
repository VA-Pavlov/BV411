using System.Diagnostics;
using BV411.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            string result = "";
            for(int i = 0; i < productRipositorie.products.Count; i++)
            {
                result += productRipositorie.products[i];
            }
            return result;
        }
    }
}