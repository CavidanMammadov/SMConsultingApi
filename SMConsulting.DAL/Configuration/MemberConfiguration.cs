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
    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasKey(x => x.MemberId);

            builder.HasIndex(x => x.MemberId);

            builder.Property(x => x.MemberFullName)
                .IsRequired();

            builder.Property(x => x.MemberPosition)
                .IsRequired();

            builder.Property(x => x.MemberImage)
                .IsRequired(false);

            builder.Property(x => x.MemberPhone)
                .IsRequired();

            builder.Property(x => x.MemberEmail)
                .IsRequired(false);

            builder.Property(x => x.MemberDescription)
                .IsRequired();

        }
    }
}
