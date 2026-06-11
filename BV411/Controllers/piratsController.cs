using BV411.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class piratsController : Controller
    {
        public ActionResult Index()
        {
            return View(reposi.products);
        }
    }
}
