using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guarda.Core.Entities
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
        public int DiscountPercent { get; set; }
        public bool StockStatus { get; set; }
        public string Image { get; set; }
        public IFormFile ImageFile { get; set; }
        public bool IsClassic { get; set; }
        public bool IsSport { get; set; }
        public bool IsSmart { get; set; }
        public bool IsLike { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? UpdateAt { get; set; }

        //Subcategory

        public int SubcategoryId { get; set; }
        public Subcategory Subcategory { get; set; }

        //Product comment
        public int ProductCommentId { get; set; }
        public ProductComment Comment { get; set; }
    }
}
