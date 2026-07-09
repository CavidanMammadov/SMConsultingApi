using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMConsulting.Core;
using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.DAL.Configuration
{
    public class SectorHelpConfiguration : IEntityTypeConfiguration<SectorHelp>
    {
        public void Configure(EntityTypeBuilder<SectorHelp> builder)
        {
            builder.HasKey(x => x.SectorHelpId);

            builder.HasOne(x => x.Sector)
              .WithMany(x => x.SectorHelps)
              .HasForeignKey(x => x.SectorHelpSectorId);
        }
    }
}
