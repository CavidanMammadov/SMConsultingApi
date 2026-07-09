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
    public class CardSpecificationConfiguration : IEntityTypeConfiguration<CardSpecification>
    {
        public void Configure(EntityTypeBuilder<CardSpecification> builder)
        {
            builder.HasKey(x => x.CardSpecificationId);

            builder.HasIndex(x => x.CardSpecificationId);

            builder.Property(x => x.CardSpecificationTitle)
                .IsRequired();

            builder.Property(x => x.CardSpecificationIcon)
                .IsRequired(false);

        }
    }
}
