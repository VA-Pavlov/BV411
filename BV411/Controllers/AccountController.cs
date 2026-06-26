using BV411.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV411.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Auth()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string login, string password)
        {
            var user = UserRepos.Get(login, password);

            if (user == null)
            {
                ViewBag.Error = "Неверный логин или пароль";
                return View();
            }

            HttpContext.Session.SetInt32("UserId", user.Id);

            return RedirectToAction("Index", "Product");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(
            string login,
            string password,
            string email,
            string phone)
        {
            if (UserRepos.Exists(login))
            {
                ViewBag.Error = "Такой пользователь уже существует";
                return View();
            }

            var user = UserRepos.Register(
                login,
                password,
                email,
                phone);

            HttpContext.Session.SetInt32("UserId", user.Id);

            return RedirectToAction("Index", "Product");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Product");
        }
    }
}