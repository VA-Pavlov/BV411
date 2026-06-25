using BV411.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class piratsController : Controller
    {
        public ActionResult Index()
        {
            return View(DataBase.DATABASEEntities.getContext().Products);
        }
        public ActionResult add(int id)
        {
            BasketRip.GetBasket(0).Products.Add(reposi.products[id]);
            return RedirectToAction("Index");
        }
    }
}
