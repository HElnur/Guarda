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
    internal class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(c => c.Text)
                .HasMaxLength(300)
                .IsRequired();

            builder.Property(c => c.Email)
                .HasMaxLength(100);

            builder.Property(c => c.FullName)
                .HasMaxLength(50);

            builder.Property(c => c.Created)
                .HasDefaultValueSql("GETUTCDATE()");    

            builder.Property(c => c.Rate)
                .IsRequired(true);
        }
    }
}
