using Microsoft.AspNetCore.Mvc;

namespace Guarda.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}
