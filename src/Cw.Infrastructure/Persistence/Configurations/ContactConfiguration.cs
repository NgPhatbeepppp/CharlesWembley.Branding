using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cw.Domain.Entities;

namespace Cw.Infrastructure.Persistence.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> b)
        {
            b.ToTable("Contacts", "cms");
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();

            b.Property(x => x.FullName).HasMaxLength(200);
            b.Property(x => x.Email).HasMaxLength(320);
            b.Property(x => x.Phone).HasMaxLength(50);
            b.Property(x => x.Message).HasMaxLength(2000);
            b.Property(x => x.IpAddress).HasMaxLength(45);
            b.Property(x => x.Processed).HasDefaultValue(false);

            b.Property(x => x.CreatedAt).HasColumnType("datetime2");
        }
    }
}
