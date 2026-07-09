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
    public class SocialMediaConfiguration : IEntityTypeConfiguration<SocialMedia>
    {
        public void Configure(EntityTypeBuilder<SocialMedia> builder)
        {
            builder.HasKey(x => x.SocialMediaId);
            builder.HasIndex(x => x.SocialMediaId);

            builder.Property(x => x.SocialMediaFacebookUrl)
                .IsRequired()
                .HasMaxLength(1024);
            builder.Property(x => x.SocialMediaInstagramUrl)
                .IsRequired()
                .HasMaxLength(1024);
            builder.Property(x=>x.SocialMediaLinekdinUrl)
                .IsRequired()
                .HasMaxLength(1024);
            builder.Property(x=>x.SocialMediaYoutubeUrl)
                .IsRequired()
                .HasMaxLength(1024);
        }
    }
}
