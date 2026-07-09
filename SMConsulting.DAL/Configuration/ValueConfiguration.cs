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
    public class ValueConfiguration : IEntityTypeConfiguration<Value>
    {
        public void Configure(EntityTypeBuilder<Value> builder)
        {
            builder.HasKey(x => x.ValueId);

            builder.Property(x => x.ValueTitle)
                   .IsRequired();

            builder.Property(x => x.ValueDescription)
                   .IsRequired();

            builder.Property(x => x.ValueFooterTitle)
                   .IsRequired();

            builder.Property(x => x.ValueFooterDescription)
                   .IsRequired();
        }
    }
}
