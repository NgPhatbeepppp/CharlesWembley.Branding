using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cw.Domain.Entities;

namespace Cw.Infrastructure.Persistence.Configurations
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> b)
        {
            b.ToTable("ProductCategories", "cms");
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();

            b.Property(x => x.CreatedAt).HasColumnType("datetime2");
            b.Property(x => x.UpdatedAt).HasColumnType("datetime2");

            b.Property(x => x.IsDeleted).HasDefaultValue(false);

            // Optional tree
            b.HasOne<ProductCategory>()
                .WithMany()
                .HasForeignKey(x => x.ParentId)
                .OnDelete(DeleteBehavior.Restrict);

            // IconMediaId (optional) -> SET NULL or RESTRICT
            b.HasOne<MediaAsset>()
                .WithMany()
                .HasForeignKey(x => x.IconMediaId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
