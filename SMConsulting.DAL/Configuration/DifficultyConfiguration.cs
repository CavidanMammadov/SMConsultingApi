using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMConsulting.Core.Entities;
using System.Numerics;

namespace SMConsulting.DAL.Configuration
{
    public class DifficultyConfiguration : IEntityTypeConfiguration<Difficulty>
    {
        public void Configure(EntityTypeBuilder<Difficulty> builder)
        {
            builder.HasKey(x => x.DifficultyId);

            builder.HasOne(x => x.SectorHelp)
              .WithMany(x => x.Difficulties)
              .HasForeignKey(x => x.DifficultSectorHelpId);
        }
    }
}
