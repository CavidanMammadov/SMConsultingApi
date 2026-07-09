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
    public class PartnerConfiguration : IEntityTypeConfiguration<Partner>
    {
        public void Configure(EntityTypeBuilder<Partner> builder)
        {
            builder.HasKey(x => x.PartnerId);

            builder.HasIndex(x => x.PartnerId);

            builder.Property(x => x.PartnerName)
                .IsRequired();

            builder.Property(x => x.PartnerDescription)
                .IsRequired();

            builder.Property(x => x.PartnerImage)
                .IsRequired(false);

            builder.Property(x => x.PartnerWebsiteUrl)
                .IsRequired(false);

        }
    }
}
