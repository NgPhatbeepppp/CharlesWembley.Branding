using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cw.Domain.Entities;

namespace Cw.Infrastructure.Persistence.Configurations
{
    public class SettingTranslationConfiguration : IEntityTypeConfiguration<SettingTranslation>
    {
        public void Configure(EntityTypeBuilder<SettingTranslation> b)
        {
            b.ToTable("SettingTranslations", "cms");
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();

            b.Property(x => x.LanguageCode).HasMaxLength(5).IsRequired();
            b.Property(x => x.Value).HasMaxLength(2000);

            b.HasIndex(x => new { x.SettingId, x.LanguageCode }).IsUnique();

            b.HasOne<Setting>()
                .WithMany()
                .HasForeignKey(x => x.SettingId)
                .OnDelete(DeleteBehavior.Cascade);

            b.HasOne<Language>()
                .WithMany()
                .HasForeignKey(x => x.LanguageCode)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
