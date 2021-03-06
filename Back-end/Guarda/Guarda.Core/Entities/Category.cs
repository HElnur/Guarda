
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guarda.Core.Entities
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<Subcategory> Subcategories { get; set; }
        public string Image { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
