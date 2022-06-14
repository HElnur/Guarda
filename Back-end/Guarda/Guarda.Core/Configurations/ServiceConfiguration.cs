using Guarda.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guarda.Core.Configurations
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Services>
    {
        public void Configure(EntityTypeBuilder<Services> builder)
        {
            builder.Property(s => s.Name).HasMaxLength(25).IsRequired(true);
            builder.Property(s => s.Description).HasMaxLength(30).IsRequired(true);
            builder.Property(s => s.Image).HasMaxLength(100).IsRequired(true);
            builder.Ignore(s => s.ImageFile);
        }
    }
}
