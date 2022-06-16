using Guarda.Core.Entities;

namespace Guarda.ViewModels
{
    public class HomeViewModel
    {
        public List<Services> Services { get; set; }
        public List<HomeSlider> HomeSliders { get; set; }
        public List<Product> ClassicProducts { get; set; }
        public List<Product> SportProducts { get; set; }
        public List<Product> SmartProducts { get; set; }
        public List<Product> LikedProducts { get; set; }
    }
}
