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
    public class ServiceConfiguration : IEntityTypeConfiguration<Services>
    {
        public void Configure(EntityTypeBuilder<Services> builder)
        {
            builder.Property(s => s.Name).HasMaxLength(50).IsRequired();

            builder.Property(s => s.Description).HasMaxLength(50).IsRequired();

            builder.Property(s => s.Image).HasMaxLength(100);

            builder.Ignore(s => s.ImageFile);
        }
    }
}
