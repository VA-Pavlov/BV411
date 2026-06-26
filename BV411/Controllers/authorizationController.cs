using Microsoft.AspNetCore.Mvc;
using BV411.Models.rip;
using BV411.Models.transport;

namespace BV411.Controllers
{
    public class authorizationController : Controller
    {
        public IActionResult Index(bool a)
        {
            return View(a);

        }
        [HttpPost]
        public IActionResult Index(string login, string pas)
        {
            foreach (var item in UserRip.users)
            {
                if(item.Password == pas && item.Login == login)
                {
                    UserRip.ActivUser = item;
                    return RedirectToAction("Index", "pirats", new HomeTransport() { User = item});
                }
            }
            return RedirectToAction("Index", false);
        }
        [HttpPost]
        public IActionResult Login(string login, string password)
        {
            string authData = $"Login: {login}   Password: {password}";
            return Content(authData);
        }
    }
}
