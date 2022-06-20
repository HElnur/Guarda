using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guarda.Core.Entities
{
    public class Services:BaseEntity
    {
        public string Name { get; set; }    
        public string Description { get; set; }
        public string Image { get; set; }
        public IFormFile ImageFile { get; set; }

    }
}
