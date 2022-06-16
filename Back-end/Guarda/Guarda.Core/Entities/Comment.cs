using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guarda.Core.Entities
{
    public class Comment:BaseEntity
    {
        public int ProductId { get; set; }
        public string AppUserId { get; set; }
        public string Text { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public DateTime Created { get; set; }
        public bool Status { get; set; }
        public int Rate { get; set; }
        public Product Product { get; set; }
        public AppUser AppUser { get; set; }

    }
}
