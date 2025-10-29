using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cw.Domain.Entities;

namespace Cw.Infrastructure.Persistence.Configurations
{
    public class LogoConfiguration : IEntityTypeConfiguration<Logo>
    {
        public void Configure(EntityTypeBuilder<Logo> b)
        {
            b.ToTable("Logos", "cms");
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();

            b.Property(x => x.Title).HasMaxLength(200);
            b.Property(x => x.LinkUrl).HasMaxLength(512);
            b.Property(x => x.SortOrder).HasDefaultValue(0);

            b.HasOne<MediaAsset>()
                .WithMany()
                .HasForeignKey(x => x.MediaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
