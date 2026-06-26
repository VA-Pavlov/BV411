using BV411.Models.rip;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class accountController : Controller
    {
        
        public ActionResult Index()
        {
            return View(UserRip.ActivUser);
        }
    }
}
