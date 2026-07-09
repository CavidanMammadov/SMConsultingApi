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
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(x => x.ContactId);

            builder.HasIndex(x => x.ContactId);

            builder.Property(x => x.ContactAdress)
                   .IsRequired();

            builder.Property(x => x.ContactPhone)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(x => x.ContactEmail)
                   .IsRequired()
                   .HasMaxLength(256);
        }
    }
}
