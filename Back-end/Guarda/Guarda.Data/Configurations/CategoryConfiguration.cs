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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Name).HasMaxLength(50).IsRequired();

            builder.Property(c => c.CreatedAt).HasDefaultValueSql("GETUTCDATE()");

            builder.Property(c => c.Image).HasMaxLength(100);

            builder.Ignore(c => c.ImageFile);
        }
    }
}
