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
    public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.HasKey(x => x.RefreshTokenId);

            builder.Property(x => x.RefreshTokenToken)
                   .IsRequired()
                   .HasMaxLength(500);

            builder.HasIndex(x => x.RefreshTokenToken)
                   .IsUnique();

            builder.Property(x => x.RefreshTokenUserId)
                   .IsRequired();

            builder.Property(x => x.RefreshTokenExpireTime)
                   .IsRequired();

            builder.Property(x => x.RefreshTokenCreatedAt)
                   .IsRequired();

            builder.Property(x => x.RefreshTokenIsRevoked)
                   .HasDefaultValue(false);

            builder.HasOne(x => x.User)
        .WithMany()
        .HasForeignKey(x => x.RefreshTokenUserId)
        .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
