using Microsoft.AspNetCore.Mvc;

namespace Guarda.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult MyWishlist()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }
    }
}
