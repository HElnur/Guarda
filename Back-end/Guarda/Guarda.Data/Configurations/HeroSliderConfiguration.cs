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
    public class HeroSliderConfiguration : IEntityTypeConfiguration<HeroSlider>
    {
        public void Configure(EntityTypeBuilder<HeroSlider> builder)
        {
            builder.Property(s => s.Image).HasMaxLength(100);
            builder.Property(s => s.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
            builder.Ignore(s => s.ImageFile);
        }
    }
}
