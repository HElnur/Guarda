using Guarda.Data.DAL;
using Guarda.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Guarda.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            HomeViewModel homeVM = new HomeViewModel
            {
                HeroSliders = _context.HeroSlider.ToList(),
                Services = _context.Services.ToList(),
                Categories = _context.Categories.ToList(),
                IsClassic = _context.Products.Where(x => x.Subcategory.Name == "Classic").ToList(),
                IsLike = _context.Products.Where(x => x.IsLike).ToList(),


            };

            return View(homeVM);
        }

       
    }
}