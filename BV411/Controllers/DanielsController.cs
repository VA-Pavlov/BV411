using BV411.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class DanielsController : Controller
    {
        public IActionResult Index()
        {
            return View(DanikRepos.Daniks);
        }

        public IActionResult Info(int id)
        {
            Danik danik = DanikRepos.Daniks.FirstOrDefault(x => x.Id == id);
            return View(danik);
        }
    }
}
