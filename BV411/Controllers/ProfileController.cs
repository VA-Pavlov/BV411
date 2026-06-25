using BV411.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class ProfileController : Controller
    {
        // страница входа / регистрации
        public IActionResult Index()
        {
            return View();
        }

        // LOGIN
        [HttpPost]
        public IActionResult Login(string login, string password)
        {
            var user = UserRepos.Login(login, password);

            if (user == null)
                return RedirectToAction("Index");

            HttpContext.Session.SetInt32("UserId", user.Id);

            return RedirectToAction("Profile");
        }

        // REGISTER (если ты его используешь)
        [HttpPost]
        public IActionResult Register(User model)
        {
            var user = UserRepos.Register(model);

            HttpContext.Session.SetInt32("UserId", user.Id);

            return RedirectToAction("Profile");
        }

        // PROFILE
        public IActionResult Profile()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return RedirectToAction("Index");

            var user = UserRepos.GetById(userId.Value);

            return View(user);
        }

        // LOGOUT
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        // EDIT (GET)
        public IActionResult Edit()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return RedirectToAction("Index");

            var user = UserRepos.GetById(userId.Value);

            return View(user);
        }

        // EDIT (POST)
        [HttpPost]
        public IActionResult Edit(User model)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return RedirectToAction("Index");

            model.Id = userId.Value;

            UserRepos.Update(model);

            return RedirectToAction("Profile");
        }
    }
}