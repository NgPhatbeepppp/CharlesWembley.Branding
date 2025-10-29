using Cw.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cw.Infrastructure.Persistence.Configurations;

public class ProductTranslationConfiguration : IEntityTypeConfiguration<ProductTranslation>
{
    public void Configure(EntityTypeBuilder<ProductTranslation> b)
    {
        b.ToTable("ProductTranslations", AppDbContext.Schema);

        b.HasKey(x => new { x.ProductId, x.LanguageCode });

        b.Property(x => x.LanguageCode).HasMaxLength(5).IsRequired();
        b.Property(x => x.Name).HasMaxLength(200).IsRequired();
        b.Property(x => x.Slug).HasMaxLength(220).IsRequired();
        b.Property(x => x.ShortDescription).HasMaxLength(1000);
        b.Property(x => x.MetaTitle).HasMaxLength(70);
        b.Property(x => x.MetaDescription).HasMaxLength(160);

        b.HasIndex(x => new { x.LanguageCode, x.Slug })
            .IsUnique()
            .HasDatabaseName("UX_Product_Lang_Slug");

        b.HasOne(x => x.Product)
            .WithMany(p => p.Translations)
            .HasForeignKey(x => x.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        b.HasOne(x => x.Language)
            .WithMany(l => l.ProductTranslations)
            .HasForeignKey(x => x.LanguageCode)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
