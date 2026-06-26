using BV411.Models.rip;
using BV411.Models.transport;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class piratsController : Controller
    {
        public ActionResult Index()
        {
            return View(new HomeTransport() { User = UserRip.ActivUser});
        }
        public ActionResult add(int id)
        {
            UserRip.ActivUser.Basket.addProduct(reposi.products[id]);
            return RedirectToAction("Index");
        }
    }
}
