using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cw.Domain.Entities;

namespace Cw.Infrastructure.Persistence.Configurations
{
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> b)
        {
            b.ToTable("News", "cms");
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();

            b.Property(x => x.PublishAt).HasColumnType("datetime2");
            b.HasIndex(x => x.PublishAt);

            b.Property(x => x.CreatedAt).HasColumnType("datetime2");
            b.Property(x => x.UpdatedAt).HasColumnType("datetime2");
            b.Property(x => x.IsDeleted).HasDefaultValue(false);
        }
    }
}
