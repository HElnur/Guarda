using Guarda.Core.Entities;

namespace Guarda.ViewModels
{
    public class HomeViewModel
    {
        public List<HeroSlider> HeroSliders { get; set; }
        public List<Services> Services { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> IsClassic { get; set; }
        public List<Product> IsSport { get; set; }
        public List<Product> IsSmart { get; set; }
        public List<Product> IsLike { get; set; }
        public List<Product> IsSuggestion { get; set; }

    }
}
