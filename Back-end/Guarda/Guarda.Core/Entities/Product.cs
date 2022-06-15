﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guarda.Core.Entities
{
    internal class Product:BaseEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
        public int DiscountPercent { get; set; }
        public bool IsDeleted { get; set; } 
        public bool StockStatus { get; set; }
        public bool IsClassic { get; set; }
        public bool IsSport { get; set; }
        public bool IsSmart { get; set; }

    }
}