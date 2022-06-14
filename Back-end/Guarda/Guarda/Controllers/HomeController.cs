//using Guarda.Models;
using Guarda.Data.DAL;
using Guarda.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Guarda.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Services = _context.Services.ToList(),
                HomeSliders = _context.HomeSliders.ToList(),
            };
            
            return View(homeVM);
        }

    }
}