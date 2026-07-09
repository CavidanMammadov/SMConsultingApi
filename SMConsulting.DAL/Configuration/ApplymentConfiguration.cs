using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.DAL.Configuration
{
    public class ApplymentConfiguration : IEntityTypeConfiguration<Applyment>
    {
        public void Configure(EntityTypeBuilder<Applyment> builder)
        {
            builder.HasKey(x => x.AppylmentId);
            builder.HasIndex(x => x.AppylmentId);
            builder.Property(x => x.ApplymentName)
                .IsRequired()
                .HasMaxLength(128);
            builder.Property(x => x.ApplymentEmail)
                .IsRequired()
                .HasMaxLength(256);
            builder.Property(x => x.ApplymentPhone)
                .IsRequired()
                .HasMaxLength(32);
            builder.Property(x => x.ApplymentCompany)
    .HasMaxLength(256)
    .IsRequired(false);

            builder.Property(x => x.ApplymentPosition)
                .HasMaxLength(128)
                .IsRequired(false);

            builder.Property(x => x.ApplymentMessage)
                .HasMaxLength(2048)
                .IsRequired(false);
        }
    }
}
