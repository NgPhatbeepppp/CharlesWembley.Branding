using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cw.Domain.Entities;

namespace Cw.Infrastructure.Persistence.Configurations
{
    public class AuditLogConfiguration : IEntityTypeConfiguration<AuditLog>
    {
        public void Configure(EntityTypeBuilder<AuditLog> b)
        {
            b.ToTable("AuditLogs", "cms");
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();

            b.Property(x => x.Event).HasMaxLength(200);
            b.Property(x => x.CreatedAt).HasColumnType("datetime2");
            b.Property(x => x.Actor).HasMaxLength(200);
        }
    }
}
