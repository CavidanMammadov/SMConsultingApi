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
    public class AboutConfiguration : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.HasKey(x => x.AboutId);
            builder.HasIndex(x => x.AboutId);
            builder.Property(x=>x.AboutTitle).IsRequired();
            builder.Property(x=>x.AboutDescription).IsRequired();
        }
    }
}
