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
        //Personal info
        public string FullName { get; set; }

        //Role info
        public bool IsAdmin { get; set; }

        //Audit info
        public DateTime CreatedAt { get; set; }

        //Deletable entity
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }


    }
}
