using Microsoft.AspNetCore.Mvc;

namespace Guarda.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult Forgot()
        {
            return View();
        }

        public IActionResult ResetPassword()
        {
            return View();
        }
    }
}
