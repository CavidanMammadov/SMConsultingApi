using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMConsulting.Core.Entities;

namespace SMConsulting.DAL.Configuration
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasKey(x => x.BlogId);

            builder.HasIndex(x => x.BlogId);

            builder.Property(x => x.BlogTitle)
                .IsRequired();

            builder.Property(x => x.BlogMainImage)
                .IsRequired(false);

            builder.Property(x => x.BlogSecondaryImage)
                .IsRequired(false);

            builder.Property(x => x.BlogMainContent)
                .IsRequired();

            builder.Property(x => x.BlogSubcontent)
                .IsRequired();

            builder.Property(x => x.BlogTags)
                .IsRequired();
        }
    }
}
