using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guarda.Core.Entities
{
    public class SubBrand:BaseEntity
    {
        public int SubcategoryId { get; set; }
        public int BrandId { get; set; }

        public Subcategory Subcategory { get; set; }
        public Brand Brand { get; set; }
    }
}
