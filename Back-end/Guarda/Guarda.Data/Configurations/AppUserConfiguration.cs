using Guarda.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guarda.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(a => a.FullName).HasMaxLength(50);

            builder.Property(a => a.CreatedAt).HasDefaultValueSql("GETUTCDATE()");

            builder.Property(a => a.Email).HasMaxLength(100);
        }
    }
}
