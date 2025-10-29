using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cw.Domain.Entities;

namespace Cw.Infrastructure.Persistence.Configurations
{
    public class ProductCategoryProductConfiguration : IEntityTypeConfiguration<ProductCategoryProduct>
    {
        public void Configure(EntityTypeBuilder<ProductCategoryProduct> b)
        {
            b.ToTable("ProductCategoryProducts", "cms");
            b.HasKey(x => new { x.ProductId, x.CategoryId });

            b.Property(x => x.SortOrder).HasDefaultValue(0);

            // FK to Product (CASCADE)
            b.HasOne<Product>()
                .WithMany()
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            // FK to Category (CASCADE)
            b.HasOne<ProductCategory>()
                .WithMany()
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
