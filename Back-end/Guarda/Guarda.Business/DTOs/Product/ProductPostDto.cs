using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guarda.Business.DTOs.Product
{
    public class ProductPostDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //public string Image { get; set; }
        public IFormFile ImageFile { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
        public int DiscountPercent { get; set; }
        public bool IsDeleted { get; set; }
        public bool StockStatus { get; set; }
        public bool IsClassic { get; set; }
        public bool IsSport { get; set; }
        public bool IsSmart { get; set; }
    }

    public class ProductPostDtoValidator : AbstractValidator<ProductPostDto>
    {
        public ProductPostDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Not empty!");

            RuleFor(x => x.DiscountPercent)
                .GreaterThanOrEqualTo(0)
                .LessThanOrEqualTo(100);
        }
    }
}
