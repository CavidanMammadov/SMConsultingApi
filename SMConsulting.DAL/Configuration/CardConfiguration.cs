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
    public class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasKey(x => x.CardId);
            builder.HasIndex(x => x.CardId);
            builder.Property(x=>x.CardDescription)
                .IsRequired();  
            builder.Property(x=>x.CardIcon) .IsRequired(false);
            builder.Property(x=>x.CardTitle) .IsRequired(false);
        }
    }
}
