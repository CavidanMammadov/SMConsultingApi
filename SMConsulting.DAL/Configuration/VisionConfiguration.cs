using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.DAL.Configuration
{
    public class VisionConfiguration : IEntityTypeConfiguration<Vision>
    {
        public void Configure(EntityTypeBuilder<Vision> builder)
        {
            builder.HasKey(x => x.VisionId);
            builder.Property(x=>x.VisionSubDescription).IsRequired();
            builder.Property(x=>x.VisionDescription).IsRequired();

        }
    }
}
