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
    public class HomeSliderConfiguration : IEntityTypeConfiguration<HomeSlider>
    {
        public void Configure(EntityTypeBuilder<HomeSlider> builder)
        {
            builder.Property(h => h.Image).HasMaxLength(100).IsRequired(true);
            builder.Ignore(h => h.ImageFile);
        }
    }
}
