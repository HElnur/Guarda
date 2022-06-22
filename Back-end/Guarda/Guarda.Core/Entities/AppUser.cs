using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guarda.Core.Entities
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }

        //Audit info
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        //Deletable info
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
