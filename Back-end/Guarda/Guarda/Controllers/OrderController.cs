using Microsoft.AspNetCore.Mvc;

namespace Guarda.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Wishlist()
        {
            return View();
        }

        public IActionResult Basket()
        {
            return View();
        }
    }
}
