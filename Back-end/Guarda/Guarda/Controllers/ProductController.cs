using Guarda.Business.DTOs.Product;
using Guarda.Core.Entities;
using Guarda.Data.DAL;
using Guarda.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Guarda.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            //Product product = _context.Products.Include(x => x.Category).Include(x => x.Comments).FirstOrDefault(p => p.Id == id);

            //ProductDetailViewModel productDetailVM = new ProductDetailViewModel
            //{
            //    Product = product,
            //    RelatedProducts = _context.Products.Include(x => x.)
            //};
            return View();
        }
    }
}
