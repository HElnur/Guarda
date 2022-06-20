using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guarda.Core.Entities
{
    public class Subcategory:BaseEntity
    {
        public string Name { get; set; }

        //Category connection
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
