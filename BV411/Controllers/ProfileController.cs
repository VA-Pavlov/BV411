using BV411.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            int? userId =
                HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction(
                    "Login",
                    "Account");
            }

            var user = UserRepos.Get(userId.Value);

            return View(user);
        }
        public IActionResult Edit()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return RedirectToAction("Login", "Account");

            var user = UserRepos.Get(userId.Value);

            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User model)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return RedirectToAction("Login", "Account");

            var user = UserRepos.Get(userId.Value);

            user.Login = model.Login;
            user.Email = model.Email;
            user.Phone = model.Phone;
            user.Avatar = model.Avatar;

            return RedirectToAction("Index");
        }
    }
}