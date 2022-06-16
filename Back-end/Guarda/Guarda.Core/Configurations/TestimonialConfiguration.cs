
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
    public class TestimonialConfiguration : IEntityTypeConfiguration<Testimonial>
    {
        public void Configure(EntityTypeBuilder<Testimonial> builder)
        {
            builder.Property(t => t.Customer)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(t => t.CustomerPosition)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(t => t.Image)
                .HasDefaultValueSql("user.png");

            builder.Property(t => t.Description)
                .HasMaxLength(300)
                .IsRequired();

            builder.Ignore(t => t.ImageFile);
        }
    }
}
