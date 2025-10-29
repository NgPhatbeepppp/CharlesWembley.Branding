using Cw.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cw.Infrastructure.Persistence.Configurations;

public class LanguageConfiguration : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> b)
    {
        b.ToTable("Languages", AppDbContext.Schema);
        b.HasKey(x => x.LanguageCode);
        b.Property(x => x.LanguageCode).HasMaxLength(5);
        b.Property(x => x.Name).HasMaxLength(50).IsRequired();
    }
}
