using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cw.Domain.Entities;

namespace Cw.Infrastructure.Persistence.Configurations
{
    public class MediaAssetConfiguration : IEntityTypeConfiguration<MediaAsset>
    {
        public void Configure(EntityTypeBuilder<MediaAsset> b)
        {
            b.ToTable("MediaAssets", "cms");
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();

            b.Property(x => x.FileName).HasMaxLength(255).IsRequired();
            b.Property(x => x.StoragePath).HasMaxLength(1024).IsRequired();
            b.Property(x => x.ContentType).HasMaxLength(100);
            b.Property(x => x.Hash).HasMaxLength(128);
            b.Property(x => x.SizeBytes);

            b.HasIndex(x => x.Hash).IsUnique(false);
        }
    }
}
