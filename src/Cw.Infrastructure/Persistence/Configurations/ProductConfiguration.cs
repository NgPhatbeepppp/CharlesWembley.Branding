using Cw.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cw.Infrastructure.Persistence.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> b)
    {
        b.ToTable("Products", AppDbContext.Schema);
        b.HasKey(x => x.Id);
        b.HasIndex(x => x.PublishedAt).HasDatabaseName("IX_Products_PublishedAt");

        b.Property(x => x.IsPublished).HasDefaultValue(true);
        b.Property(x => x.CreatedAt).HasColumnType("datetime2");
        b.Property(x => x.UpdatedAt).HasColumnType("datetime2");
        b.Property(x => x.DeletedAt).HasColumnType("datetime2");
    }
}
