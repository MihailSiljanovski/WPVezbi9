using Microsoft.AspNetCore.Mvc;
using Vezbi9.Models;

namespace Vezbi9.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // Authenticate user
                if (model.Username == "admin" && model.Password == "password")
                {
                  
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }
            }

            return View(model);
        }
    }
}
