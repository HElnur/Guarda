﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guarda.Core.Entities
{
    public class HeroSlider:BaseEntity
    {
        public string Image { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
