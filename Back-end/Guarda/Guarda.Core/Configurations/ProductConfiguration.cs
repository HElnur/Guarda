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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name)
                .HasMaxLength(30)
                .IsRequired(true);

            builder.Property(p => p.Description)
                .HasMaxLength(200)
                .IsRequired(true);

            builder.Property(p => p.CostPrice)
                .IsRequired(true)
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.SalePrice)
                .IsRequired(true)
                .HasColumnType("decimal(18,2)");

            builder.Ignore(p => p.ImageFile);

        }
    }
}
