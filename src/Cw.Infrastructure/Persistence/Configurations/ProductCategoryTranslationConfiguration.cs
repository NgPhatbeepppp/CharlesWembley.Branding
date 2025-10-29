using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cw.Domain.Entities;

namespace Cw.Infrastructure.Persistence.Configurations
{
    public class ProductCategoryTranslationConfiguration : IEntityTypeConfiguration<ProductCategoryTranslation>
    {
        public void Configure(EntityTypeBuilder<ProductCategoryTranslation> b)
        {
            b.ToTable("ProductCategoryTranslations", "cms");
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();

            b.Property(x => x.LanguageCode).HasMaxLength(5).IsRequired();
            b.Property(x => x.Name).HasMaxLength(200).IsRequired();
            b.Property(x => x.Slug).HasMaxLength(220).IsRequired();
            b.Property(x => x.Summary).HasMaxLength(1000);
            b.Property(x => x.MetaTitle).HasMaxLength(70);
            b.Property(x => x.MetaDescription).HasMaxLength(160);

            // UNIQUE (LanguageCode, Slug)
            b.HasIndex(x => new { x.LanguageCode, x.Slug }).IsUnique();

            // FK to Category (CASCADE)
            b.HasOne<ProductCategory>()
                .WithMany()
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            // FK to Languages (RESTRICT)
            b.HasOne<Language>()
                .WithMany()
                .HasForeignKey(x => x.LanguageCode)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
