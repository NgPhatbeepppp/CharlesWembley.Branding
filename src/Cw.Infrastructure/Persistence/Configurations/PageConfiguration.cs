using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cw.Domain.Entities;

namespace Cw.Infrastructure.Persistence.Configurations
{
    public class PageConfiguration : IEntityTypeConfiguration<Page>
    {
        public void Configure(EntityTypeBuilder<Page> b)
        {
            b.ToTable("Pages", "cms");
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();

            b.Property(x => x.Code).HasMaxLength(100).IsRequired();
            b.HasIndex(x => x.Code).IsUnique();

            b.Property(x => x.CreatedAt).HasColumnType("datetime2");
            b.Property(x => x.UpdatedAt).HasColumnType("datetime2");
            b.Property(x => x.IsDeleted).HasDefaultValue(false);
        }
    }
}
