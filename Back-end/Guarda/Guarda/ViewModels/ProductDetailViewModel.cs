using Guarda.Core.Entities;

namespace Guarda.ViewModels
{
    public class ProductDetailViewModel
    {
        public Product Product { get; set; }
        public List<Product> RelatedProducts { get; set; }
        public Comment Comment { get; set; }
    }
}
