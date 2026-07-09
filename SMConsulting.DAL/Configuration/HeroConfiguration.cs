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
    public class HeroConfiguration : IEntityTypeConfiguration<Hero>
    {
        public void Configure(EntityTypeBuilder<Hero> builder)
        {
            builder.HasKey(x => x.HeroId);
            builder.HasIndex(x => x.HeroId);
            builder.Property(x => x.HeroTitle)
                .IsRequired();

            builder.Property(x=>x.HeroDescription)
                .IsRequired();

            builder.Property(x=>x.HeroImageUrl)
                .IsRequired();
        }
    }
}
