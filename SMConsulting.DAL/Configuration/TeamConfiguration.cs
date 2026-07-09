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
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(x => x.TeamId);

            builder.HasIndex(x => x.TeamId);

            builder.Property(x => x.TeamTitle)
                .IsRequired();

            builder.Property(x => x.TeamTitleHiglight)
                .IsRequired();

            builder.Property(x => x.TeamDescription)
                .IsRequired();

        }
    }
}
