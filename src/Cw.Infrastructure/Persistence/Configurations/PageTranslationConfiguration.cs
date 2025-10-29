using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cw.Domain.Entities;

namespace Cw.Infrastructure.Persistence.Configurations
{
    public class PageTranslationConfiguration : IEntityTypeConfiguration<PageTranslation>
    {
        public void Configure(EntityTypeBuilder<PageTranslation> b)
        {
            b.ToTable("PageTranslations", "cms");
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();

            b.Property(x => x.LanguageCode).HasMaxLength(5).IsRequired();
            b.Property(x => x.Title).HasMaxLength(200).IsRequired();
            b.Property(x => x.Slug).HasMaxLength(220).IsRequired();
            b.Property(x => x.Summary).HasMaxLength(1000);
            b.Property(x => x.MetaTitle).HasMaxLength(70);
            b.Property(x => x.MetaDescription).HasMaxLength(160);

            b.HasIndex(x => new { x.LanguageCode, x.Slug }).IsUnique();

            b.HasOne<Page>()
                .WithMany()
                .HasForeignKey(x => x.PageId)
                .OnDelete(DeleteBehavior.Cascade);

            b.HasOne<Language>()
                .WithMany()
                .HasForeignKey(x => x.LanguageCode)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
