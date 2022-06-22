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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();    

            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();

            builder.Property(p => p.SalePrice).HasColumnType("decimal(18,2)").IsRequired(true);

            builder.Property(p => p.CostPrice).HasColumnType("decimal(18,2)").IsRequired(true);

            builder.Property(p => p.Image).HasMaxLength(100);



            builder.Ignore(p => p.ImageFile);
        }
    }
}
