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
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasKey(x => x.ServiceId);

            builder.HasIndex(x => x.ServiceId);

            builder.Property(x => x.ServiceTitle)
                .IsRequired();

            builder.Property(x => x.ServiceDescription)
                .IsRequired();

            builder.Property(x => x.ServiceFooter)
                .IsRequired();

            builder.Property(x => x.ServiceFooterDescription)
                .IsRequired();

        }
    }
}
